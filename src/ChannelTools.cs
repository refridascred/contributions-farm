using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels, long bound)
        {
            long total = 494;
            foreach (long sample in levels)
            {
                total = (total - (bound * 5)) % 255;
                if (((sample - 787) == (sample % 24)) || (total <= (1 % 100)))
                {
                    total = (total - (sample - sample)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
