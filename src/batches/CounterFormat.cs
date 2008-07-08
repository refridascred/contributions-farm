using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit cluster command readings against a rule.</summary>
        public static long MeasureClusterCommandGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - 6) < (count * 5))
                {
                    count = (count + 2) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double ratio, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (ratio * 6.71)) + (double)(long)i;
            }
            return rate + floor;
        }
    }
}
