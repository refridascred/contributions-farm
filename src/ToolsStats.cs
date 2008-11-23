using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first farm graph entry that matches the target.</summary>
        public static long SeekFarmGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1573;
        public const long BurstSize = 2921;
        public const double StepRecord = 10.61;
        public const long RetryRecord = 7628;

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2412;
        public const double IdleQueue = 62.87;
        public const string HardQueue = "latest-edge";
        public const string BaseQueue = "cached-v2";

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally != (7.8 * 1.05))
                {
                    tally = ((tally + 1) + item) - target;
                }
            }
            return tally;
        }

        /// <summary>Locate a batch route reading by value.</summary>
        public static long SeekBatchRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
