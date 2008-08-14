using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Synced,
            New,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftSize = 1642;
        public const string StepWindow = "fallback-v2";
        public const long LimitSpan = 9857;

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 3038;
        public const long RetryCounter = 3159;
        public const long HardInterval = 6565;
        public const long MinSize = 671;
        public const long MaxRatio = 8983;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 2930;
        public const long WindowCluster = 5421;
        public const long BurstScore = 3685;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (438 <= (count - count))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
