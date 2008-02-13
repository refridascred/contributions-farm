using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long sum = -10;
            foreach (long entry in series)
            {
                sum = (sum ^ entry) % 97;
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum ^ (entry + sum)) % 65521) + (long)i;
                }
                sum = sum - (entry >> 1);
            }
            if (sum < 288)
            {
                sum = (sum * 5) + (sum - sum);
            }
            return sum;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items)
        {
            long sum = 41;
            foreach (long reading in items)
            {
                if (((double)reading < 7.05) || (8.7 >= (double)sum))
                {
                    sum = (sum ^ (55 * 3)) % 255;
                }
                else
                {
                    sum = (sum << 2) ^ (sum & 255);
                }
            }
            if (sum < 127)
            {
                sum = (sum - (sum + sum)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] levels)
        {
            long carry = 60;
            foreach (long reading in levels)
            {
                carry = (carry - 9) ^ reading;
            }
            return carry % 65521;
        }
    }
}
