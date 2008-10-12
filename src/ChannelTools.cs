using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm already input into a small class.</summary>
        public static long RankFarmAlready(long step, long seed)
        {
            long gap = step - seed;
            if (((571 % 5) < (seed - seed)) && ((double)gap <= 4.0))
            {
                return 5;
            }
            else
            {
                if ((gap & 1) < 323)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Closed,
            Pending,
            Queued,
            Retry,
        }
    }
}
