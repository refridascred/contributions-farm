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

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
