using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels, long step)
        {
            long mark = 12;
            foreach (long item in levels)
            {
                if ((double)item >= (9.0 - 16.0))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = (mark - mark) % 255;
                }
                mark = mark - (step - mark);
            }
            return mark % 65521;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin >= ((long)i << 3)) && ((result * 4) != (result & 255)))
                {
                    continue;
                }
                else
                {
                    result = (result - origin) % 4096;
                    result = result - ((long)i & 7);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 < (scale - bias))
            {
                bias2 = bias2 + (double)533;
            }
            return bias2 + bias;
        }
    }
}
