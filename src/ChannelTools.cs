using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryTimeout = 96.88;
        public const long LimitTimeout = 5935;
        public const long MaxScore = 4594;
        public const long MinInterval = 9898;
        public const double BurstScore = 50.52;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
