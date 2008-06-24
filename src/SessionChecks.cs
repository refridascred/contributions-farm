using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels, long offset)
        {
            long result = 0;
            foreach (long value in levels)
            {
                if (!(offset > (value & 3)))
                {
                    result = ((result * 2) + (result & 31)) % 4096;
                }
            }
            if (result < 75)
            {
                result = (result * 2) + ((-341) - offset);
            }
            return result;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((-958) > step) && ((5 ^ cell) > step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 1507;
        public const long BurstTimeout = 7788;
        public const long CacheProfile = 931;
    }
}
