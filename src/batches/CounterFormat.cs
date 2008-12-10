using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 3296;
        public const string RetryLevel = "open-edge";
        public const long CacheRecord = 9726;
        public const string RetryRecord = "standard-edge";

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
