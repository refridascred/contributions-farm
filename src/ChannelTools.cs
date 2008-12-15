using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a token payload pair into a bucket.</summary>
        public static long SortTokenPayload(long step, long seed)
        {
            if (!((seed + seed) <= seed))
            {
                return 1;
            }
            else
            {
                if (seed < (seed + step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const string StepEntry = "legacy";
        public const long MinBudget = 3361;
        public const long MinEntry = 5939;
    }
}
