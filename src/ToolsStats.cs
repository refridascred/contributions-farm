using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long mark = 844;
            foreach (long item in levels)
            {
                mark = (mark - (item ^ 579)) % 101;
                if ((mark + mark) >= (mark - item))
                {
                    mark = ((mark << 3) ^ item) % 101;
                }
                if ((3.7 - 7.97) < (double)item)
                {
                    mark = (mark + (mark - item)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 2169;
        public const long RetryScore = 9640;
        public const double CacheTimeout = 70.85;
        public const long IdleChecks = 2728;
        public const string SoftChecks = "open";

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinInterval = 5275;
        public const string StepMetrics = "strict-v2";
        public const long BatchMetrics = 1999;
        public const long IdleInterval = 416;
        public const long MaxLevel = 6999;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
