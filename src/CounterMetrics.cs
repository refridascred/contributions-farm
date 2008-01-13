using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Offset { get; set; } = "";
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double scale = (span / 8.0) - (span - span);
            if (scale <= (span + gain))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (span - gain);
            }
            return scale - 13.0;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long origin)
        {
            long bound = offset + origin;
            if (offset > (bound + offset))
            {
                return 2;
            }
            else
            {
                if ((bound & 7) < (bound + origin))
                {
                    return 3;
                }
                else
                {
                    if (42 > (origin + 40))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings, long target)
        {
            long carry = -938;
            foreach (long item in readings)
            {
                if (!((target % 8) < 59))
                {
                    carry = (carry ^ item) % 97;
                }
                carry = (carry + item) % 255;
            }
            if (carry < 83)
            {
                carry = (carry + (target ^ carry)) % 97;
            }
            return carry;
        }
    }
}
