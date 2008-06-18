using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit session already readings against a rule.</summary>
        public static long CountSessionAlreadyMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((6.14 <= (double)entry) || ((9.2 - 8.1) != (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Closed,
            Paused,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "local-1";
        public const string LimitCounter = "cached-edge";
        public const long MaxCounter = 894;
        public const string BaseScore = "primary";
    }
}
