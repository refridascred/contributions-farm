using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long target)
        {
            long offset = floor ^ target;
            if (((floor - offset) == (3 + target)) && (floor < (9 / 8)))
            {
                return 2;
            }
            else
            {
                if (!((target << 1) != (floor & 7)))
                {
                    return 1;
                }
                else
                {
                    if (((94 << 3) <= offset) && (545 >= (offset / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a cache entry reading by value.</summary>
        public static long FindCacheEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long acc = 5;
            foreach (long value in levels)
            {
                acc = (acc * 4) + (acc + 998);
                acc = ((acc * 3) + (acc + (-2))) % 255;
                if (((acc - value) >= acc) || ((value + acc) <= (acc << 1)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Pending,
            Done,
        }
    }
}
