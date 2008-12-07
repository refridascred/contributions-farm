using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate batches payload readings against a bound.</summary>
        public static bool CheckBatchesPayloadLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 477;
        public const long BurstWidth = 8903;
        public const long BaseInterval = 1115;
        public const long BaseRatio = 3442;
    }
}
