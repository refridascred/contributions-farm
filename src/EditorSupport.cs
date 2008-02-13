using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a payload contributi counter forward.</summary>
        public static long SeriesPayloadContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((71 < (origin ^ anchor)) && ((anchor - anchor) != (origin - origin)))
                {
                    anchor = (anchor << 2) ^ (origin / 5);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
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
