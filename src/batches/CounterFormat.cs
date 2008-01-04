using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double weight, double span)
        {
            double bias = span;
            return (bias - span) + weight;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally <= (5.0 / 6.0))
                {
                    tally = ((tally + 1) + value) - floor;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] items, long limit)
        {
            long mark = -212;
            foreach (long item in items)
            {
                mark = ((mark + (mark * 2)) - item) - limit;
            }
            if (mark > 6)
            {
                mark = (mark - 7) % 4096;
            }
            return mark % 65521;
        }
    }
}
