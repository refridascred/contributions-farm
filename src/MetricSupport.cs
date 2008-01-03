using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data)
        {
            long acc = 919;
            foreach (long sample in data)
            {
                if ((sample + (-5)) > 93)
                {
                    acc = ((acc << 2) ^ (acc + 7)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double mean = span / 2.0;
            return (mean - (double)3) + scale;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            New,
            Idle,
            Queued,
        }
    }
}
