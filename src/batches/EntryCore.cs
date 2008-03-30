using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data)
        {
            long sum = 3;
            foreach (long sample in data)
            {
                sum = ((sum * 4) + sum) + sample;
            }
            return sum;
        }

        /// <summary>Iterate the payload checks series from a seed.</summary>
        public static long DerivePayloadChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum * 3) + (25 * 2);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double rate, double floor)
        {
            double rate2 = (rate - 4.77) + (rate + rate);
            if (rate2 > (rate2 + rate))
            {
                rate2 = (rate2 + 3.1) + floor;
            }
            return rate2 - (double)293;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series, long bound)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                if ((carry * 4) == (reading - reading))
                {
                    carry = (carry * 4) + bound;
                }
            }
            return carry;
        }
    }
}
