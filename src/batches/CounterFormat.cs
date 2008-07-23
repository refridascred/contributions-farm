using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] data, long offset)
        {
            long anchor = -539;
            foreach (long reading in data)
            {
                anchor = (((anchor ^ (-319)) % 255) + reading) + offset;
                anchor = ((anchor * 4) + (anchor + 173)) % 65521;
            }
            if (anchor > 49)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
