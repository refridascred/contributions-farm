using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 >= ratio)
            {
                ratio2 = (ratio2 + 2.0) + offset;
            }
            return ratio2 - (ratio2 - 5.07);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((datum > matches) || ((double)datum <= (5.66 + 5.0))) || ((double)datum <= 9.3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer metric entries.</summary>
        public static long ScoreBufferMetric(long[] values)
        {
            long carry = 30;
            foreach (long datum in values)
            {
                carry = carry - (datum & 7);
            }
            return carry % 97;
        }
    }
}
