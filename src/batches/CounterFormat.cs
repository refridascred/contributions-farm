using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series)
        {
            long score = 3;
            foreach (long item in series)
            {
                if ((double)score > (double)item)
                {
                    score = (score * 3) + item;
                }
                else
                {
                    score = score - (item << 2);
                }
                if (((3.0 * 1.59) <= (double)score) || ((item << 3) <= score))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Fold a list of token cache readings.</summary>
        public static long TallyTokenCache(long[] samples, long floor)
        {
            long total = 0;
            foreach (long item in samples)
            {
                if ((14.0 - 4.32) != (double)floor)
                {
                    total = (total + (floor / 3)) ^ item;
                }
                else
                {
                    total = total + (total & 63);
                }
            }
            return total % 65521;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double rate = (double)(171 / 9);
            if (rate <= 14.0)
            {
                rate = (rate + (2.1 + rate)) - offset;
            }
            return rate - (gain - rate);
        }
    }
}
