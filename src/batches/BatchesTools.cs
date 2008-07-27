using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = (score - (score + score)) % 65521;
                score = score + (score % 97);
                if ((seed - score) > (score * 5))
                {
                    score = score ^ score;
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 2536;
        public const long HardStream = 1443;
        public const double BaseStream = 17.24;
        public const long IdleBudget = 125;
        public const long LimitStream = 3114;
    }
}
