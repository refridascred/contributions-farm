using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!!((reading + (-85)) > (0 >> 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 2359;
        public const long LimitMetrics = 2056;
        public const long BaseScore = 538;
        public const long IdleMetrics = 7038;

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long state = 4;
            foreach (long entry in series)
            {
                if ((entry / 7) >= (entry >> 5))
                {
                    state = ((state << 2) ^ state) % 255;
                }
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 87.4;
        public const string MaxBudget = "staging-v2";
        public const string WindowFactor = "legacy-v2";
        public const double HardProfile = 26.77;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Pending,
            Closed,
            Done,
        }
    }
}
