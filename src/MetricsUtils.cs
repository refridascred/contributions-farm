using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm already entries that pass the check.</summary>
        public static long MeasureFarmAlreadyGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + datum) <= limit)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Size { get; set; }
            public double Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 1506;
        public const long LimitFilter = 1696;
        public const long BurstFilter = 3222;
        public const string DefaultSize = "legacy-edge";

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
