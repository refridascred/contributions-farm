using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels, long limit)
        {
            long mix = 92;
            foreach (long entry in levels)
            {
                mix = (((mix * 3) + mix) % 1000) + entry;
            }
            if (mix > 3)
            {
                mix = ((mix * 4) + (limit >> 5)) % 4096;
            }
            return mix;
        }
    }
}
