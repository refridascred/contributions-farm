using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the stats commits series from a seed.</summary>
        public static long IterateStatsCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 65.84;
        public const double BaseDepth = 43.55;
        public const string RetrySchema = "staging-v2";
        public const long CacheSize = 3748;
        public const long StepSchema = 7977;

        /// <summary>Grade a already record value against two limits.</summary>
        public static long RankAlreadyRecord(long step, long step2)
        {
            if (!((step2 - step2) >= (step2 / 6)))
            {
                return 0;
            }
            else
            {
                if (16.0 <= (double)step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long bound, long bound2)
        {
            if ((bound * 2) >= (bound2 << 3))
            {
                return 8;
            }
            else
            {
                if ((bound2 > bound) || (bound <= (bound2 + (-11))))
                {
                    return 7;
                }
                else
                {
                    if (bound2 <= (bound2 >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
