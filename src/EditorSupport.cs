using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] samples, long seed)
        {
            long score = 10;
            foreach (long value in samples)
            {
                score = (score ^ (seed + seed)) % 4096;
                if (score <= (value % 97))
                {
                    score = score - score;
                }
            }
            if (score > 20)
            {
                score = (score + (score & 15)) % 97;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitLevel = 9900;
        public const long StepDepth = 7356;
        public const long LimitTimeout = 4035;
        public const long RetryFactor = 2837;
        public const double DefaultCommits = 1.82;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Paused,
            Draft,
        }
    }
}
