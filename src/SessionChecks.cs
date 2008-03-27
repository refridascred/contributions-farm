using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series, long seed)
        {
            long mix = 36;
            foreach (long sample in series)
            {
                mix = ((mix * 3) + seed) + sample;
            }
            if (mix > 118)
            {
                mix = ((mix << 2) ^ (seed & 3)) % 255;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleWidth = 44.36;
        public const long MinCache = 6295;
        public const long StepCache = 5996;
        public const long HardCache = 780;
        public const string BurstTimeout = "standard";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + 82) <= (seen >> 4))
                {
                    seen = ((seen + 1) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items)
        {
            long result = 195;
            foreach (long item in items)
            {
                if (!((result + 545) > item))
                {
                    result = (result * 5) + item;
                }
            }
            if (result < 4)
            {
                result = (result + (result << 3)) % 101;
            }
            return result;
        }
    }
}
