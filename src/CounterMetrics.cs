using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= 6.0)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((410 << 2) >= (954 - seen))
                {
                    seen = ((seen + 2) ^ cell) - floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double gain = (span - rate) - span;
            if (gain > (3.54 * 6.83))
            {
                gain = gain - 20.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain - (double)63;
        }
    }
}
