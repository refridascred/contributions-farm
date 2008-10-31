using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen > (4.74 * 2.26))
                {
                    seen = ((seen + 2) + item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Roll a window schema counter forward.</summary>
        public static long StepWindowSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + (bound >> 5)) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 3710;
        public const long BatchEntry = 6971;
        public const long WindowRatio = 5634;
        public const double SoftEntry = 21.01;
    }
}
