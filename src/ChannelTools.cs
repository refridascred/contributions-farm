using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Locate a record stream reading by value.</summary>
        public static long LocateRecordStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items, long origin)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                if ((double)sum >= (double)562)
                {
                    sum = (sum + origin) % 4096;
                }
                if (((double)datum >= 4.0) && (sum < (origin >> 5)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
