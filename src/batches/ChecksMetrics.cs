using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinTimeout = 6242;
        public const long DefaultBatches = 4725;
        public const long SoftBatches = 8004;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] samples)
        {
            long result = -74;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= 4.86)
                {
                    result = (result - (6 & 7)) + datum;
                }
            }
            if (result > 491)
            {
                result = (result ^ result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleLevel = 8042;
        public const long DefaultRatio = 2378;
        public const string WindowFactor = "primary-1";

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Queued,
            Active,
            Ready,
            Paused,
        }
    }
}
