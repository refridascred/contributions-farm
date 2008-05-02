using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate contributi format samples.</summary>
        public static long TotalContributiFormat(long[] series, long step)
        {
            long acc = 6;
            foreach (long cell in series)
            {
                acc = ((acc + 59) % 97) - step;
                acc = ((acc * 5) + cell) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] levels, long seed)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                if (item <= (item - acc))
                {
                    acc = ((acc - (262 / 2)) % 101) + seed;
                }
            }
            return acc % 4096;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > bias2)
            {
                mean = mean - (mean / 2.0);
            }
            return mean - bias;
        }
    }
}
