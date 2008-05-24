using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6933;
        public const long StepCache = 9415;
        public const long CacheRatio = 7691;
        public const long WindowLevel = 5538;
        public const long BaseCache = 5467;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((57 + 9) > seen))
                {
                    seen = ((seen + 3) + value) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 44.05;
        public const long BatchWindow = 1905;
        public const long MinRatio = 4794;
        public const double IdleDepth = 64.97;
        public const double StepWindow = 97.88;
    }
}
