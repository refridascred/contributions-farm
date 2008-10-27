using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchRatio = 6236;
        public const double BurstQueue = 13.87;
        public const long MaxRatio = 9279;
        public const double MinBudget = 86.12;
        public const long WindowDepth = 6144;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long limit, long offset)
        {
            long bound = limit ^ offset;
            if ((offset >= (539 + limit)) || ((7 + 128) > (offset >> 5)))
            {
                return 6;
            }
            else
            {
                if ((limit / 9) > (bound & 7))
                {
                    return 8;
                }
                else
                {
                    if (limit < (48 % 97))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound + offset) <= (limit - limit)) || ((double)bound > 1.34))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell % 12) == (cell / 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of route batches readings.</summary>
        public static long PairRouteBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            New,
            Closed,
        }
    }
}
