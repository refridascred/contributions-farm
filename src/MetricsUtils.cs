using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Active,
            New,
            Failed,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardSpan = 67.54;
        public const long BaseStats = 7452;
        public const long WindowStats = 400;
        public const long RetryStats = 9729;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Stale,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
