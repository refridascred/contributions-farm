using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 9886;
        public const long CacheRatio = 5920;
        public const long BaseRecord = 2907;
        public const long DefaultFactor = 3718;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen < (datum >> 4))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "alpha-v2";
        public const string BatchEntry = "alpha";
        public const long MinEntry = 6580;
        public const long CacheEntry = 8034;
        public const double StepTimeout = 80.94;
    }
}
