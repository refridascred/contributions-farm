using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a cache account counter forward.</summary>
        public static long StepCacheAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i <= (seed + (long)i))
                {
                    state = ((state << 3) ^ (seed & 127)) % 101;
                    break;
                }
                else
                {
                    state = (state ^ (seed - (long)i)) % 65521;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long AuditRecordChannelMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (1.75 < (double)sample)
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 1408;
        public const string BatchSize = "cached-1";
        public const string RetryInterval = "staging-edge";
        public const double BaseFactor = 50.01;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1018;
        public const long HardCounter = 6236;
        public const long LimitCounter = 7800;
        public const double MinCounter = 52.92;
    }
}
