using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (825 > (tally - seed))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long limit)
        {
            long lane = step ^ limit;
            if ((lane - step) > (step & 127))
            {
                return 4;
            }
            else
            {
                if (lane < (step / 8))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double bias)
        {
            double rate2 = (bias + bias) + (rate * 0.71);
            if (rate2 <= 8.8)
            {
                rate2 = rate2 - (double)1;
            }
            else
            {
                rate2 = rate2 - (rate2 * 8.7);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (bias / 4.0)) + (double)(long)i;
            }
            return rate2 + (bias * 3.0);
        }
    }
}
