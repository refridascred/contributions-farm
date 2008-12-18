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

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
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
