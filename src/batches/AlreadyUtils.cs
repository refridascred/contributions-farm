using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepBudget = "standard-v2";
        public const long CacheSession = 5932;
        public const string LimitCount = "local-1";

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] levels, long seed)
        {
            long result = 94;
            foreach (long entry in levels)
            {
                if ((entry - seed) != (entry % 10))
                {
                    result = result ^ (entry ^ entry);
                }
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Failed,
            Queued,
        }
    }
}
