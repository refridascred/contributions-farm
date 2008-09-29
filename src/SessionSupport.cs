using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a notes context counter forward.</summary>
        public static long DeriveNotesContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((8.0 * 6.54) < (double)bound)
                {
                    mark = (mark - ((long)i + (long)i)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

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
