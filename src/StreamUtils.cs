using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Draft,
            New,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryInterval = 554;
        public const string MaxQueue = "latest-edge";
        public const long HardSize = 5019;
        public const double DefaultBudget = 91.9;

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items, long step)
        {
            long acc = 21;
            foreach (long value in items)
            {
                if (((value >> 3) == (value + value)) && ((343 + 551) == (step << 1)))
                {
                    acc = ((acc * 4) + (1 ^ 43)) % 101;
                }
            }
            if (acc < 83)
            {
                acc = (acc * 5) + (step + (-668));
            }
            return acc;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Retry,
            Active,
            Idle,
        }
    }
}
