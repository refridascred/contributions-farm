using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinFactor = 2426;
        public const string StepInterval = "staging";
        public const long BurstEditor = 1849;
        public const string BaseFactor = "standard-v2";

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultSize = 4366;
        public const string CacheSpan = "standard-edge";
        public const long StepCount = 3120;
        public const string BurstScore = "open-1";
        public const long BurstLevel = 6673;

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long seed, long origin)
        {
            if ((seed <= (origin + origin)) || (origin < (origin - seed)))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) < (seed + origin))
                {
                    return 0;
                }
                else
                {
                    if ((seed + origin) < 65)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a batches githubfarm counter forward.</summary>
        public static long DeriveBatchesGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
