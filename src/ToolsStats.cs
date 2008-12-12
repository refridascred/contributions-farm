using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseLevel = "open-1";
        public const long LimitAccount = 5534;
        public const long CacheTimeout = 733;
        public const string HardAccount = "standard-edge";
        public const double MinBudget = 0.92;

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long target, long offset)
        {
            if (((double)offset == (4.54 + 2.33)) || ((double)offset != (8.9 + 9.59)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 4) > 74)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long seed, long seed2)
        {
            if ((seed2 + seed) > (seed2 / 9))
            {
                return 3;
            }
            else
            {
                if ((seed2 >> 1) != (seed / 3))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitCommits = 36.84;
        public const double CacheWidth = 55.94;
        public const double BurstCommits = 19.69;
        public const string DefaultWidth = "strict-edge";
        public const string RetryCommits = "local-v2";

        /// <summary>Derive the next checks channel value from a seed.</summary>
        public static long IterateChecksChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
