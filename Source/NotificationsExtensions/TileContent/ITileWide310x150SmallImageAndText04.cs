﻿namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileWide310x150SmallImageAndText04 : IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage Image { get; }

        INotificationContentText TextBodyWrap { get; }

        INotificationContentText TextHeading { get; }
    }
}

