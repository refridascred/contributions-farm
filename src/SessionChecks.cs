using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long floor)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                mix = (mix + (cell / 4)) + floor;
            }
            if (mix > 7)
            {
                mix = mix ^ (mix >> 3);
            }
            return mix;
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
