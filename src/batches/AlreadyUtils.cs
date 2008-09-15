using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor ^ seed;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((681 + limit) != (item & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a farm queue value against two limits.</summary>
        public static long RankFarmQueue(long target, long target2)
        {
            if ((target << 3) >= (target - target2))
            {
                return 5;
            }
            else
            {
                if ((1.6 - 7.4) < (double)target2)
                {
                    return 2;
                }
                else
                {
                    if ((double)target2 < 9.8)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowScore = 16.4;
        public const double SoftFarm = 80.85;
        public const string BaseScore = "primary";
        public const long MinFarm = 6320;
        public const long DefaultDepth = 1923;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
