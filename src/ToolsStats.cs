using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2601;
        public const long DefaultQueue = 2147;
        public const double BaseWidth = 46.57;
        public const long BaseCount = 7356;

        /// <summary>Roll a stream editor counter forward.</summary>
        public static long SeriesStreamEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Closed,
            New,
            Queued,
            Idle,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (3.88 + 16.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetrySize = "staging-edge";
        public const long LimitInterval = 7695;
        public const long DefaultStream = 6157;
        public const long BurstBudget = 6017;
    }
}
