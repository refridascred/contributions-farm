using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine filter already values into a single score.</summary>
        public static long ScoreFilterAlready(long[] data)
        {
            long total = 26;
            foreach (long item in data)
            {
                total = (total ^ (2 * 5)) + item;
                total = total ^ (78 ^ 3);
            }
            return total % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 9506;
        public const string IdleBatches = "primary-v2";
        public const long LimitWidth = 405;
        public const long CacheBatches = 4160;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Dropped,
            Stale,
            Failed,
            Ready,
        }
    }
}
