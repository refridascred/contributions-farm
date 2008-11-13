using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first token cache entry that matches the target.</summary>
        public static long SeekTokenCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long target, long floor)
        {
            if (((floor >> 2) <= (floor * 5)) && (target <= (91 + 695)))
            {
                return 6;
            }
            else
            {
                if ((7 + 244) == (floor / 4))
                {
                    return 7;
                }
                else
                {
                    if (floor > (target + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor ^ floor) >= (target & 63))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            Paused,
            Active,
        }
    }
}
