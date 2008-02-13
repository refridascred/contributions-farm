using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitFactor = "staging-v2";
        public const long MaxBudget = 7299;
        public const long IdleGithubfarm = 8757;
        public const long BaseSpan = 3817;

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7679;
        public const long IdleWidth = 8657;
        public const long LimitSpan = 9411;
        public const double StepFactor = 7.92;
        public const string StepCommand = "fallback";

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Queued,
            Synced,
        }
    }
}
