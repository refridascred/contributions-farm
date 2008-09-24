using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Dropped,
            Failed,
            Done,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 8364;
        public const long LimitFactor = 6176;
        public const long MaxWindow = 8422;
        public const string MaxInterval = "alpha-v2";
        public const string SoftDepth = "local-1";

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long target, long seed)
        {
            if ((200 >> 4) <= target)
            {
                return 2;
            }
            else
            {
                if (((target - target) >= (seed << 2)) && ((9.0 + 9.07) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
