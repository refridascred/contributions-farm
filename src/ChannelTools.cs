using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            Locked,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((377 - target) == (target - count)) && (((cell - target) != (cell & 15)) || ((target % 8) < count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
