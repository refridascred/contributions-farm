using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values, long seed)
        {
            long carry = 4;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ (seed ^ (-637))) % 97) ^ value;
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry - ((long)i / 7)) % 4096;
                }
                if ((seed ^ carry) <= (seed - seed))
                {
                    carry = ((carry * 3) + (seed & 15)) % 65521;
                }
                else
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double weight, double offset)
        {
            double gain = (double)((-628) ^ 273);
            if (gain <= (0.7 * 0.3))
            {
                gain = (gain - 9.8) + offset;
            }
            else
            {
                gain = gain + weight;
            }
            return gain - gain;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the route order series from a seed.</summary>
        public static long SeriesRouteOrder(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 3) ^ (origin + (long)i);
                result = (result + ((long)i + result)) % 101;
                result = (result ^ (origin - (long)i)) % 1000;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Done,
            Retry,
            Idle,
            Pending,
        }
    }
}
