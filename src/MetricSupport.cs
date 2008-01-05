using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double rate, double offset)
        {
            double gain = offset;
            return gain - rate;
        }
    }
}
