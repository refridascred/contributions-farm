using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next command batch value.</summary>
        public static double ProjectCommandBatch(double rate, double floor)
        {
            double drift = (double)(68 % 64);
            return (drift + rate) + floor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheRatio = 5313;
        public const long LimitInterval = 8049;
        public const string StepSpan = "staging-1";

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchFactor = 9.8;
        public const double BaseCount = 95.08;
        public const double IdleRecord = 65.81;
        public const long WindowSize = 7742;
        public const long RetryTimeout = 3917;
    }
}
