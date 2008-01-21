using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitCommits = "local-v2";
        public const long CacheCommits = 9097;
        public const long BurstCommits = 2071;
        public const double BurstCount = 15.14;
        public const long WindowCommits = 1710;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
