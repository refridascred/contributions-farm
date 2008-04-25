using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardInterval = 32.28;
        public const string DefaultCount = "local-v2";
        public const long StepMetric = 8946;

        /// <summary>Measure how many format account samples are out of range.</summary>
        public static long AuditFormatAccountGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading - origin) >= (count - reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (9.0 <= (double)sample)
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
