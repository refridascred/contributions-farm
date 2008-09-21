using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSize = 6257;
        public const string WindowBuffer = "standard-edge";
        public const long BatchBuffer = 3432;
        public const long BaseBudget = 8672;

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 7395;
        public const long IdleMetric = 8657;
        public const double MinDepth = 84.52;
        public const string IdleFactor = "local";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryDepth = 6236;
        public const double MaxCluster = 97.47;
        public const long BurstTimeout = 9121;
    }
}
