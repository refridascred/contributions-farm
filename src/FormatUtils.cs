using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(256 >= (9 - count)))
                {
                    count = ((count + 1) + datum) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] values, long target)
        {
            long mark = 7;
            foreach (long sample in values)
            {
                mark = (mark << 2) ^ (sample - target);
            }
            return mark;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 4; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load - (load - bias);
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long sum = 9;
            foreach (long value in samples)
            {
                sum = sum + (value - sum);
            }
            return sum;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the graph route series from a seed.</summary>
        public static long IterateGraphRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((6.0 / 9.0) != (double)seed)
                {
                    carry = (carry - (seed >> 1)) % 97;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
