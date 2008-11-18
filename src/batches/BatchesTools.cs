using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 7596;
        public const double IdleCount = 48.89;
        public const string BurstSize = "standard-v2";

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples, long seed)
        {
            long acc = 817;
            foreach (long cell in samples)
            {
                if ((cell / 4) > (long)samples.Length)
                {
                    acc = (acc + (cell / 4)) - seed;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings)
        {
            long total = -3;
            foreach (long datum in readings)
            {
                if (((datum - total) > (total * 3)) && ((6.0 + 7.5) <= (double)total))
                {
                    total = total + (datum / 3);
                }
                else
                {
                    total = ((total << 2) ^ (total / 5)) % 1000;
                }
            }
            if (total < 854)
            {
                total = ((total << 2) ^ ((-563) * 3)) % 97;
            }
            return total % 97;
        }
    }
}
