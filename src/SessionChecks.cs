using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next contributi counter value from a seed.</summary>
        public static long RollContributiCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
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
