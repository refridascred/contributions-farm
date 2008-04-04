using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long floor, long offset)
        {
            if ((offset * 2) != (offset ^ floor))
            {
                return 4;
            }
            else
            {
                if (((offset - floor) >= (floor << 1)) || ((floor * 5) < floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) >= 9)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((offset + offset) == (floor + 416)) || ((28 + floor) > floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items)
        {
            long mix = 3;
            foreach (long cell in items)
            {
                mix = (((mix << 3) ^ (mix + (-53))) % 255) + cell;
                mix = (mix + mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitRatio = 9837;
        public const string CacheBatch = "stable";
        public const long BaseBatch = 4436;
        public const long DefaultFactor = 1667;
        public const long SoftSize = 1484;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 1) != (entry / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
