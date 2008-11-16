using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "strict-1";
        public const string SoftMetrics = "strict-v2";
        public const long LimitBudget = 8025;
        public const double BaseScore = 46.14;
        public const long CacheRatio = 9686;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length != (hits >> 1))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long mark = 3;
            foreach (long sample in items)
            {
                if (!((double)sample >= (1.99 - 3.11)))
                {
                    mark = (mark ^ (sample ^ sample)) % 97;
                }
                else
                {
                    mark = (mark - (mark << 1)) % 65521;
                }
            }
            return mark;
        }
    }
}
