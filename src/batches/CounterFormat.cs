using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a record batches figure with a bias.</summary>
        public static double AdjustRecordBatches(double ratio, double span)
        {
            double mean = span;
            if (mean < 8.86)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + (ratio / 4.0);
            }
            return mean + (span * 19.0);
        }

        /// <summary>Measure how many channel report samples are out of range.</summary>
        public static long AuditChannelReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((9.6 - 9.6) >= (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double gain = 4.0;
            if (gain < (bias * 13.0))
            {
                gain = gain - span;
            }
            return gain + (double)7;
        }
    }
}
