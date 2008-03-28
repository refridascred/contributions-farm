using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] series, long limit)
        {
            long acc = 78;
            foreach (long value in series)
            {
                if ((limit * 5) == (value ^ limit))
                {
                    acc = (acc << 2) ^ 78;
                }
            }
            return acc % 4096;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
