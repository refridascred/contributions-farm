using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (seed >= (seed % 64))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            if ((631 - offset) >= (offset / 3))
            {
                return 2;
            }
            else
            {
                if (!(((-3) ^ 965) <= (offset - offset)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
