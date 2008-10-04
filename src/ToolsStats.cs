using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 2634;
        public const long BurstAccount = 8469;
        public const double DefaultDepth = 87.33;
        public const long MaxCount = 7511;
        public const long BurstLevel = 657;

        /// <summary>Iterate the metrics entry series from a seed.</summary>
        public static long IterateMetricsEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix + (floor ^ floor)) % 1000;
                mix = mix + (447 - (long)i);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((1.3 - 8.6) == (double)seed)
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long seed, long offset)
        {
            long edge = seed - offset;
            if ((double)offset < 3.6)
            {
                return 6;
            }
            else
            {
                if (((double)seed < (13.0 - 8.6)) || ((seed + offset) >= (edge ^ offset)))
                {
                    return 4;
                }
                else
                {
                    if ((10.0 / 6.0) != (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
