using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of report token entries.</summary>
        public static long ScoreReportToken(long[] data)
        {
            long mark = 21;
            foreach (long sample in data)
            {
                if (sample < 8)
                {
                    mark = mark ^ (sample + (long)data.Length);
                }
            }
            return mark;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Find the first account buffer entry that matches the target.</summary>
        public static long FindAccountBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
