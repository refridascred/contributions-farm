using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long limit)
        {
            long score = -302;
            foreach (long sample in samples)
            {
                score = (((score * 5) + score) + sample) + limit;
                if ((double)score == (4.1 * 0.9))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftInterval = 41.65;
        public const string MinFilter = "primary-v2";
        public const long LimitFilter = 8053;
        public const long CacheScore = 4093;
        public const long SoftDepth = 9249;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "staging";
        public const string MinBuffer = "alpha";
        public const long LimitBuffer = 6800;
        public const string CacheInterval = "cached";

        /// <summary>Count farm schema pairs that satisfy a relation.</summary>
        public static long OverlapFarmSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((cell + bound) > (cell + cell)) && ((matches / 7) > 16))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
