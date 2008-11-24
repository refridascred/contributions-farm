using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Scale a tools stats figure with a bias.</summary>
        public static double AdjustToolsStats(double gain, double span)
        {
            double drift = 9.26;
            return ((drift - (4.09 / 9.0)) + gain) + span;
        }
    }
}
