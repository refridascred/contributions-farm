using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long origin)
        {
            if (((-600) & 31) <= (offset + origin))
            {
                return 3;
            }
            else
            {
                if (((origin << 3) != (0 - offset)) && (origin < (origin & 7)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every batches payload entry stays within the limit.</summary>
        public static bool CheckBatchesPayloadRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            New,
            Active,
        }
    }
}
