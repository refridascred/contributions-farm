using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long AuditPayloadClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 8093;
        public const string MaxCommand = "alpha-v2";
        public const long CacheCommand = 7229;
        public const string WindowLevel = "stable-edge";
        public const double BatchSize = 32.12;
    }
}
