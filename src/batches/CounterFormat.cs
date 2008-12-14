using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry >= (entry - hits))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 41;
        public const double WindowCluster = 93.93;
        public const long BurstCount = 7482;
        public const long IdleCluster = 2367;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long floor2)
        {
            if (((floor - floor2) <= (floor2 - floor)) && ((double)floor >= 3.0))
            {
                return 4;
            }
            else
            {
                if (floor >= (floor - floor))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
