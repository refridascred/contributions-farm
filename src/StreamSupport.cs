using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 8053;
        public const long BatchCount = 6073;
        public const string CacheSpan = "primary-edge";
        public const long LimitLevel = 5046;
        public const long MaxFactor = 1095;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Synced,
            New,
            Failed,
            Queued,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
