using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples)
        {
            long state = 11;
            foreach (long cell in samples)
            {
                state = ((state << 3) ^ (cell << 2)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 45.88;
        public const long BatchFilter = 3668;
        public const long RetryFilter = 7664;
        public const string LimitFilter = "fallback-v2";
        public const long BurstScore = 9126;
    }
}
