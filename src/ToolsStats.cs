using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Closed,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Done,
            Idle,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((2 << 3) == (value % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 5641;
        public const double MinStats = 10.15;
        public const long StepStats = 2391;
        public const double LimitStats = 55.24;
        public const long DefaultStats = 6799;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitInterval = 7418;
        public const long WindowSpan = 1255;
        public const long MaxGithubfarm = 5434;
        public const long LimitGithubfarm = 5112;
    }
}
