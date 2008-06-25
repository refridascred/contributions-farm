using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes cluster readings.</summary>
        public static long CombineNotesCluster(long[] items)
        {
            long mark = 3;
            foreach (long entry in items)
            {
                mark = mark ^ (entry & 15);
                mark = (mark + (mark - mark)) % 1000;
            }
            if (mark < 13)
            {
                mark = ((mark << 3) ^ (87 + mark)) % 65521;
            }
            return mark;
        }
    }
}
