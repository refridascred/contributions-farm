using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every profile buffer entry stays within the limit.</summary>
        public static bool CheckProfileBufferLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardCount = 7632;
        public const long BaseBatches = 7657;
        public const double LimitBatches = 85.58;
        public const string DefaultBatches = "legacy";

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Dropped,
            Failed,
        }
    }
}
