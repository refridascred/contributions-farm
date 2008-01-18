using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultInterval = 13.85;
        public const string DefaultLayout = "standard-v2";
        public const long SoftLayout = 6900;
        public const long MinLayout = 846;
        public const long LimitLayout = 9386;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Closed,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Ready,
            New,
            Draft,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "local";
        public const long MinSize = 2727;
        public const string WindowInterval = "local-edge";
        public const long BurstNotes = 254;
        public const double DefaultLevel = 17.13;

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 32.01;
        public const double CacheFactor = 13.62;
        public const string MinScore = "latest-1";
        public const long BurstStream = 8517;
        public const string RetryStream = "primary";
    }
}
