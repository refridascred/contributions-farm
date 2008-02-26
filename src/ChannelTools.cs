using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] levels, long origin)
        {
            long total = 96;
            foreach (long item in levels)
            {
                total = total - origin;
                if ((item / 4) >= (item / 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
