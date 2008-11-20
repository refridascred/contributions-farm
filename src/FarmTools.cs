using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 5392;
        public const long SoftChannel = 8001;
        public const string IdleScore = "primary-edge";
        public const long MaxChannel = 8625;
        public const long BatchChannel = 6456;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Pending,
            Synced,
            Draft,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 92.06;
        public const long LimitOrder = 9406;
        public const long CacheCount = 7690;
        public const long BurstOrder = 5068;
    }
}
