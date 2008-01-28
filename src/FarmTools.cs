using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((limit + limit) >= (count + sample))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload filter samples are out of range.</summary>
        public static long MeasurePayloadFilterMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen <= ((long)items.Length - seen))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double offset)
        {
            double rate2 = 6.4 * 4.78;
            return ((rate2 + (double)714) + rate) + offset;
        }
    }
}
