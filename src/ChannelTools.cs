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

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
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
