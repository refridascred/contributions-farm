using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 6712;
        public const long CacheContext = 1384;
        public const long RetryInterval = 6722;
        public const long HardWidth = 6016;
        public const long IdleBudget = 6037;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (0.14 * 2.57))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFactor = 6636;
        public const string DefaultCount = "fallback-1";
        public const long DefaultFormat = 2485;
        public const string BurstSpan = "open";
        public const long BurstFormat = 8101;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
