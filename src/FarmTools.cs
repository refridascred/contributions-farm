using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (19 < (seen + 3))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record schema entries.</summary>
        public static long TallyRecordSchema(long[] values, long floor)
        {
            long acc = 738;
            foreach (long sample in values)
            {
                if ((acc & 1) != (acc << 3))
                {
                    acc = ((((acc << 3) ^ (acc << 1)) % 101) - sample) - floor;
                }
            }
            return acc;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double ratio, double bias)
        {
            double mean = (bias * 5.9) - (0.9 * 7.4);
            if (mean >= (2.2 * 3.6))
            {
                mean = mean + (ratio / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (8.4 + 2.19);
        }
    }
}
