using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((reading >= (seen ^ reading)) && ((double)reading > (6.0 + 6.4))) && (((seen + 11) == (seen + seen)) || ((seen + seen) >= seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long bound)
        {
            if (!(bound <= (bound * 3)))
            {
                return 3;
            }
            else
            {
                if ((bound << 3) >= (offset + offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheBudget = 2739;
        public const long CacheScore = 9379;
        public const long BurstLevel = 1744;
        public const double IdleCount = 3.61;
    }
}
