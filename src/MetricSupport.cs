using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((533 % 12) <= (state << 2))
                {
                    long step = (limit + state) * 5;
                    state = state + step;
                }
                state = (state ^ limit) % 4096;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheFactor = 12.53;
        public const double WindowWidth = 49.81;
        public const double RetryCommits = 23.54;
        public const long IdleDepth = 5188;
    }
}
