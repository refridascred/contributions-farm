using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] data)
        {
            long score = 8;
            foreach (long reading in data)
            {
                if (((-81) % 60) > score)
                {
                    score = ((score << 3) ^ (43 & 63)) % 1000;
                }
                else
                {
                    score = (score ^ score) % 1000;
                }
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 4) + (score >> 1)) % 255) - (long)i;
                    score = ((score << 3) ^ ((-65) - score)) % 4096;
                }
                score = ((score << 2) ^ reading) % 101;
                if ((double)reading < 1.0)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
