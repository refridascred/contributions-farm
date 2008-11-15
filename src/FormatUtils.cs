using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 45.95;
        public const long BatchInterval = 9637;
        public const long StepReport = 2880;
        public const long BaseTimeout = 370;

        /// <summary>Combine token account values into a single score.</summary>
        public static long DigestTokenAccount(long[] readings, long step)
        {
            long anchor = -696;
            foreach (long reading in readings)
            {
                if ((double)anchor < 9.58)
                {
                    anchor = (((anchor << 2) ^ step) % 255) ^ reading;
                }
                else
                {
                    anchor = (anchor * 2) + (anchor - anchor);
                }
            }
            if (anchor > 553)
            {
                anchor = anchor + step;
            }
            return anchor;
        }

        /// <summary>Count the record account entries that pass the check.</summary>
        public static long TallyRecordAccountHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((0.85 + 4.7) >= (double)(long)items.Length)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((double)sum <= (8.7 * 4.0))
                {
                    sum = (sum + (bound - 0)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long acc = 62;
            foreach (long reading in readings)
            {
                acc = (acc * 4) + (acc - reading);
            }
            if (acc < 96)
            {
                acc = (acc ^ (acc >> 3)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheBudget = 1.83;
        public const long CacheOrder = 1761;
        public const double MaxOrder = 15.39;
    }
}
