using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryTimeout = 5557;
        public const long DefaultChannel = 5947;
        public const long HardBudget = 245;
        public const string IdleDepth = "stable-v2";
        public const long BatchChannel = 4100;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
