using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark << 3) ^ ((long)i % 16);
                mark = ((mark * 4) + 8) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "local-1";
        public const long StepRecord = 2266;
        public const long StepLevel = 7464;
        public const double CacheSize = 56.42;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((1 % 2) > (origin & 31)))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
