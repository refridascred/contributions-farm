using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((origin << 2) <= origin)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Closed,
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long step, long target)
        {
            long cur = step ^ target;
            if (!(target <= (target + 8)))
            {
                return 0;
            }
            else
            {
                if (((target & 255) >= (target % 5)) || (cur >= (target % 7)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
