using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 5348;
        public const long IdleContributi = 6284;
        public const long StepLevel = 1941;
        public const long RetryDepth = 9045;
        public const string WindowSize = "strict-edge";

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = score ^ (target + score);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
