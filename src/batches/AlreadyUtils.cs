using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheBudget = 43.06;
        public const double BurstSize = 18.01;
        public const long LimitSize = 4532;
        public const long BaseContext = 8492;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Queued,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstSpan = "primary-edge";
        public const long BatchFarm = 1033;
        public const long SoftFarm = 1100;
        public const string CacheFarm = "alpha-edge";
        public const long MinFarm = 8970;
    }
}
