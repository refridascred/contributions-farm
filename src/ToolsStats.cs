using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long offset, long floor)
        {
            if (offset < (offset - offset))
            {
                return 7;
            }
            else
            {
                if ((double)floor < (12.0 * 4.0))
                {
                    return 0;
                }
                else
                {
                    if ((146 >> 2) < (floor * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 38.88;
        public const long RetryLevel = 55;
        public const string SoftWidth = "local-edge";

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftBudget = 1449;
        public const long BaseSpan = 2036;
        public const long RetryCluster = 4926;
        public const long DefaultCluster = 3090;
        public const long BurstCluster = 1630;
    }
}
