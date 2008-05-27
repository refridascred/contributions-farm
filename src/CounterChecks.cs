using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long SeekCacheClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Idle,
            Done,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 9299;
        public const long LimitChannel = 7625;
        public const long WindowChannel = 1287;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
