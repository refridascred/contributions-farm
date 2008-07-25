using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            New,
            Synced,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits ^ 633) > (reading - 0)) && ((origin << 1) > origin))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleFactor = 7524;
        public const double CacheRatio = 28.11;
        public const string BaseDepth = "open-v2";
    }
}
