using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 2911;
        public const double WindowTimeout = 95.35;
        public const double BaseTimeout = 41.76;
        public const long CacheFactor = 6259;
        public const long BatchWindow = 3646;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits << 1) > hits)
                {
                    hits = ((hits + 3) ^ sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Grade a counter report value against two limits.</summary>
        public static long ClassifyCounterReport(long limit, long step)
        {
            if (limit < (7 + 47))
            {
                return 0;
            }
            else
            {
                if ((step * 5) < (step + limit))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
