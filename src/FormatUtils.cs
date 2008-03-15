using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 3673;
        public const long LimitScore = 8124;
        public const string BaseCommand = "standard-1";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long floor, long target)
        {
            if (((floor + target) != (floor + floor)) || ((83 % 3) == (target ^ floor)))
            {
                return 5;
            }
            else
            {
                if (((floor + floor) <= (target >> 1)) || ((target << 2) > target))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Active,
            Synced,
            Failed,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long seed, long bound)
        {
            long offset = seed ^ bound;
            if ((offset / 7) >= (seed % 64))
            {
                return 3;
            }
            else
            {
                if ((bound + seed) <= (seed - bound))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
