using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] readings, long seed)
        {
            long carry = -17;
            foreach (long cell in readings)
            {
                if (((carry + seed) > (cell - (-75))) || ((carry << 2) >= 739))
                {
                    carry = ((carry * 3) + (66 ^ 6)) % 4096;
                }
                if ((double)carry < (double)seed)
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = (carry * 4) + (seed - seed);
            }
            return carry;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = sum ^ (long)i;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double ratio, double bias)
        {
            double bias2 = 1.0;
            if (bias2 > (ratio + bias2))
            {
                bias2 = bias2 + (bias2 * 12.0);
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 + (bias2 + bias2);
        }
    }
}
