using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Stale,
            Queued,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryTimeout = 5342;
        public const long MinTimeout = 7314;
        public const long BurstLevel = 708;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
