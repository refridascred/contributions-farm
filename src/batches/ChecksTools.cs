using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double weight, double span)
        {
            double mean = weight + (span / 9.0);
            if (mean < (double)165)
            {
                mean = mean + (double)689;
            }
            return mean + (14.0 - mean);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((7.8 * 8.0) <= (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double bias, double bias2)
        {
            double ratio = bias2;
            return (ratio + 10.0) + bias;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
