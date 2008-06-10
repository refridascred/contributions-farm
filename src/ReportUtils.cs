using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels)
        {
            long sum = 225;
            foreach (long sample in levels)
            {
                if (sample <= (sample >> 4))
                {
                    sum = (sum + (sample - sample)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] series, long limit)
        {
            long anchor = 96;
            foreach (long reading in series)
            {
                if (anchor <= (reading + (-3)))
                {
                    anchor = anchor + (limit & 127);
                }
            }
            if (anchor > 31)
            {
                anchor = ((anchor << 2) ^ (247 ^ 7)) % 101;
            }
            return anchor % 4096;
        }
    }
}
