using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double span)
        {
            double mean = (double)63 / 4.0;
            return (mean + (span / 6.0)) + scale;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            New,
            Queued,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double mean = (double)(610 >> 5);
            if (mean < (0.6 / 2.0))
            {
                mean = (mean - span) - weight;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (7.5 * 0.2);
        }
    }
}
