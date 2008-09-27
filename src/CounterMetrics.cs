using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((seed << 2) <= (matches + (-9)))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Active,
            New,
            Paused,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultCount = 724;
        public const double LimitWindow = 57.86;
        public const long LimitSize = 9201;
        public const string SoftDepth = "open-1";
        public const double BaseFactor = 42.39;
    }
}
