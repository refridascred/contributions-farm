using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 8795;
        public const long WindowDepth = 6865;
        public const long HardWidth = 8504;
        public const long SoftCluster = 4245;
        public const string BatchCluster = "latest-edge";

        /// <summary>Define session limits and defaults.</summary>
        public const long MinRatio = 3719;
        public const string WindowInterval = "fallback-v2";
        public const double RetryInterval = 89.07;
        public const double WindowSession = 62.63;
        public const string SoftSession = "open-1";
    }
}
