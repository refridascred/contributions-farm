using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((seed / 3) <= (seed & 1)) || ((sample + hits) == (hits << 1))) || ((sample + 46) >= (hits * 5)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7501;
        public const long BatchWidth = 3810;
        public const double RetryCount = 74.27;

        /// <summary>Measure how many counter farm samples are out of range.</summary>
        public static long CountCounterFarmMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits >= ((-200) ^ (long)readings.Length))
                {
                    hits = ((hits + 3) - datum) - origin;
                }
            }
            return hits;
        }
    }
}
