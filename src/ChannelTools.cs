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

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
