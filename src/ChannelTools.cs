using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Match up record notes samples.</summary>
        public static long CompareRecordNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long seed, long origin)
        {
            long bound = seed ^ origin;
            if ((bound + bound) > seed)
            {
                return 7;
            }
            else
            {
                if ((double)origin < (double)316)
                {
                    return 1;
                }
                else
                {
                    if (((-734) / 5) >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
