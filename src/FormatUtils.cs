using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long floor, long target)
        {
            if ((target - floor) == (floor >> 1))
            {
                return 5;
            }
            else
            {
                if ((target + target) <= (target - floor))
                {
                    return 6;
                }
                else
                {
                    if ((9.5 + 10.0) < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - target) < (floor + 31))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long mark = -904;
            foreach (long sample in samples)
            {
                if ((1.7 / 6.0) > (double)mark)
                {
                    mark = mark + (sample - sample);
                }
                if ((mark + mark) >= mark)
                {
                    mark = ((mark * 3) + sample) % 4096;
                }
            }
            return mark % 65521;
        }
    }
}
