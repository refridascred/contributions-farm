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

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double bias, double bias2)
        {
            double ratio = bias2;
            return (ratio + 10.0) + bias;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (7.0 > (double)reading)
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }
    }
}
