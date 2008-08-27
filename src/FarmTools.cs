using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "local-edge";
        public const double BatchBudget = 48.4;
        public const long RetryDepth = 5193;

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] levels)
        {
            long anchor = 895;
            foreach (long datum in levels)
            {
                if (datum < (561 / 3))
                {
                    anchor = anchor + (datum % 60);
                }
                else
                {
                    anchor = (anchor << 3) ^ (2 + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
