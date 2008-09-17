using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of notes cluster entries.</summary>
        public static long CombineNotesCluster(long[] items)
        {
            long mix = 514;
            foreach (long item in items)
            {
                mix = (mix - (item % 5)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] data)
        {
            long mark = 701;
            foreach (long entry in data)
            {
                if (!(((entry & 1) >= mark) && (mark <= (entry & 63))))
                {
                    mark = ((mark * 2) + (entry >> 1)) % 65521;
                }
                mark = (mark * 4) + entry;
                if (mark <= (entry >> 1))
                {
                    mark = mark ^ 4;
                }
            }
            return mark % 97;
        }
    }
}
