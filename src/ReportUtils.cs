using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseBudget = 3331;
        public const long RetryFactor = 9567;
        public const double MinBudget = 54.39;
        public const long HardScore = 899;
        public const long DefaultDepth = 815;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Locked,
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally > (tally % 8))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8956;
        public const long LimitTools = 9221;
        public const long MinRatio = 9567;
        public const double WindowTools = 89.57;

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool ValidateChannelFarmBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
