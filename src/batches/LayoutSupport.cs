using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + (limit >> 3)) % 101) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] series)
        {
            long total = -915;
            foreach (long value in series)
            {
                total = (((total << 3) ^ (54 + total)) % 101) ^ value;
            }
            return total % 97;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < rate2)
            {
                rate2 = rate2 + (span / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + span) - (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Measure how many farm tools samples are out of range.</summary>
        public static long TallyFarmToolsHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((308 ^ offset) != (offset ^ value)) || ((offset > (value << 2)) && ((double)hits >= 0.1)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
