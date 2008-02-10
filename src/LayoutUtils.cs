using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((value + seen) == (seen - value)) || ((value - seen) < (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseFactor = 64.48;
        public const long SoftSpan = 7597;
        public const string BurstSpan = "legacy-edge";
        public const long StepWidth = 6356;
        public const long DefaultStats = 5442;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Retry,
            Ready,
            Failed,
            Idle,
        }
    }
}
