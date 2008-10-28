using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 3) ^ ((long)i << 3)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftSpan = 90.52;
        public const string DefaultTimeout = "latest";
        public const long WindowOrder = 9090;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Active,
            Locked,
            Retry,
            Synced,
        }
    }
}
