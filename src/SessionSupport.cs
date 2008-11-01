using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Ready,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool ValidateNotesMetricBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double weight, double offset)
        {
            double ratio = (offset + offset) - weight;
            if (ratio < (offset + offset))
            {
                ratio = ratio - (ratio * 15.0);
            }
            else
            {
                ratio = ratio - (double)587;
            }
            return ratio + (double)7;
        }
    }
}
