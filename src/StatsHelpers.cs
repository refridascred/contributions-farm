using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double StepCount = 14.97;
        public const long DefaultAccount = 4264;
        public const long StepTimeout = 2696;
        public const string MaxInterval = "strict";

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series)
        {
            long mark = 54;
            foreach (long value in series)
            {
                if (value > (mark - 2))
                {
                    mark = mark + value;
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "legacy-edge";
        public const double MaxFilter = 37.0;
        public const long MinFilter = 326;
        public const string StepFilter = "stable";
        public const double CacheSize = 80.05;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Active,
            Locked,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Total { get; set; }
        }
    }
}
