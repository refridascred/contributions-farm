using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine filter support values into a single score.</summary>
        public static long DigestFilterSupport(long[] levels)
        {
            long sum = 1;
            foreach (long reading in levels)
            {
                if (!((sum >> 5) > (reading + reading)))
                {
                    sum = (sum - (5 + 65)) % 97;
                }
                if ((sum - sum) > sum)
                {
                    sum = ((sum * 3) + (sum % 3)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double rate2 = floor - (double)53;
            if (rate2 <= (2.0 * 7.0))
            {
                rate2 = (rate2 - (floor * 16.0)) - rate;
            }
            return rate2 - 4.2;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell < (cell % 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
