using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a stats cache figure with a bias.</summary>
        public static double SmoothStatsCache(double scale, double floor)
        {
            double drift = (double)(2 - 59);
            return ((drift - drift) + scale) + floor;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] data)
        {
            long carry = 70;
            foreach (long item in data)
            {
                if ((1.76 - 2.0) != (double)carry)
                {
                    carry = ((carry * 2) + (item ^ item)) % 1000;
                }
            }
            if (carry < 93)
            {
                carry = carry ^ (carry - carry);
            }
            return carry;
        }
    }
}
