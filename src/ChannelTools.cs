using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double bias, double floor)
        {
            double ratio = bias - floor;
            if (ratio < (floor / 7.0))
            {
                ratio = ratio + (9.0 + floor);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (ratio - floor);
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry + (carry % 64)) % 65521) ^ (long)i2;
                }
                carry = carry - (carry & 1);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many batch farm samples are out of range.</summary>
        public static long TallyBatchFarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 2) != (tally + 271))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }
    }
}
