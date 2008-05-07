using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            New,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchInterval = 8502;
        public const long BurstInterval = 9873;
        public const double BatchCounter = 27.59;
        public const string RetryRatio = "stable-1";
        public const long BaseCounter = 2530;
    }
}
