using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = total + (long)i;
                if ((977 * 3) > (total - offset))
                {
                    total = ((total << 2) ^ (offset ^ total)) % 255;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of already support entries.</summary>
        public static long FoldAlreadySupport(long[] values, long origin)
        {
            long result = 54;
            foreach (long value in values)
            {
                if (((20.0 - 1.7) >= (double)origin) || ((result >> 1) > (origin % 2)))
                {
                    result = (result - value) % 97;
                }
            }
            return result;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double scale, double offset)
        {
            double weight = offset;
            if (weight > (double)0)
            {
                weight = weight + (scale - offset);
            }
            return weight + scale;
        }
    }
}
