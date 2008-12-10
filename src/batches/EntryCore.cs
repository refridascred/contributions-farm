using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (state * 4)) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 1939;
        public const long IdleWindow = 1582;
        public const long RetryWindow = 7002;

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long target)
        {
            if ((90 << 1) < (target >> 2))
            {
                return 8;
            }
            else
            {
                if (7.43 <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Token { get; set; }
            public double Limit { get; set; }
        }
    }
}
