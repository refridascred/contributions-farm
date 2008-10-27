using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long seed)
        {
            if ((double)target >= (1.6 * 6.9))
            {
                return 6;
            }
            else
            {
                if ((double)target < (17.0 - 2.17))
                {
                    return 5;
                }
                else
                {
                    if ((target >= (seed + target)) || ((target + seed) != (265 >> 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed >= (target + seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long floor, long offset)
        {
            if ((0 - offset) == (floor + 780))
            {
                return 1;
            }
            else
            {
                if (!(offset >= (offset + floor)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultSize = "stable";
        public const long HardOrder = 4311;
        public const double IdleSize = 72.94;
    }
}
