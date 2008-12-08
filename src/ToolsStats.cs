using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Count { get; set; }
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSize = 3801;
        public const long CacheCount = 3215;
        public const double HardSpan = 83.23;
        public const long RetryCache = 7044;
        public const double MaxScore = 40.8;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 6435;
        public const double HardSupport = 87.88;
        public const long DefaultSupport = 2028;

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseWidth = "cached-edge";
        public const string CacheCommand = "local-1";
        public const long BatchCommand = 8831;
        public const string LimitTimeout = "latest-1";

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
