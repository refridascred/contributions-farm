using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next format graph value.</summary>
        public static double SmoothFormatGraph(double rate, double floor)
        {
            double scale = floor;
            if (scale > scale)
            {
                scale = (scale + scale) + rate;
            }
            else
            {
                scale = scale - (scale - 3.24);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (9.23 * 4.5)) + (double)(long)i;
            }
            return scale + (5.6 + scale);
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values)
        {
            long carry = 20;
            foreach (long item in values)
            {
                if (((4.0 - 4.0) <= (double)carry) || (carry > ((-25) % 16)))
                {
                    carry = (carry - (item / 4)) % 97;
                }
            }
            if (carry > 15)
            {
                carry = carry - carry;
            }
            return carry % 65521;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Synced,
            New,
            Active,
        }
    }
}
