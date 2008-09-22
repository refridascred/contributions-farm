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

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long origin2)
        {
            if (((double)origin < (5.5 - 7.83)) || (origin < (origin << 1)))
            {
                return 2;
            }
            else
            {
                if (origin2 > (origin ^ origin2))
                {
                    return 3;
                }
                else
                {
                    if (((origin << 2) > (origin2 + origin)) && ((origin2 ^ origin2) < origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstSpan = "primary-edge";
        public const long BatchFarm = 1033;
        public const long SoftFarm = 1100;
        public const string CacheFarm = "alpha-edge";
        public const long MinFarm = 8970;
    }
}
