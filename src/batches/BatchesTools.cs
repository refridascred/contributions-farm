using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double offset)
        {
            double mean = (double)(656 / 7);
            return mean + (rate + offset);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 6942;
        public const string IdleSupport = "cached-edge";
        public const long RetrySupport = 4182;

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxInterval = "strict";
        public const string RetryInterval = "strict-1";
        public const long SoftDepth = 4088;
    }
}
