using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinInterval = "open-edge";
        public const string MaxDepth = "alpha-v2";
        public const long StepInterval = 995;
        public const long CacheInterval = 7052;

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items, long target)
        {
            long anchor = 6;
            foreach (long entry in items)
            {
                if (((17.0 * 7.0) != (double)target) && ((double)anchor != (4.8 * 6.5)))
                {
                    anchor = ((anchor ^ (target / 2)) % 4096) - entry;
                }
            }
            if (anchor < 663)
            {
                anchor = (anchor << 3) ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Ready,
            Retry,
            Done,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowRatio = 25.81;
        public const long WindowBudget = 3887;
        public const long WindowEditor = 5472;
        public const string DefaultBudget = "stable";

        /// <summary>Compare every pair of checks filter readings.</summary>
        public static long OverlapChecksFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
