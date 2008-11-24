using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels, long floor)
        {
            long sum = 0;
            foreach (long datum in levels)
            {
                sum = (((sum * 3) + floor) % 97) + datum;
            }
            if (sum < 231)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long origin)
        {
            if (24 < (origin * 3))
            {
                return 7;
            }
            else
            {
                if (!((limit & 3) >= origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
