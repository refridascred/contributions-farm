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

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] series)
        {
            long sum = 45;
            foreach (long entry in series)
            {
                bool found = ((entry + entry) >= 936) || ((entry / 4) >= 845);
                if (!found)
                {
                    sum = (sum + sum) % 1000;
                }
                if ((sum * 4) >= (sum ^ entry))
                {
                    sum = (sum ^ (sum % 8)) % 4096;
                }
            }
            return sum;
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
