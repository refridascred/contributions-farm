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

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2278;
        public const long DefaultBudget = 2352;
        public const long WindowToken = 4810;

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
