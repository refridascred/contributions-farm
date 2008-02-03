using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitRatio = "latest-1";
        public const double IdleDepth = 94.24;
        public const double BaseSchema = 84.9;
    }
}
