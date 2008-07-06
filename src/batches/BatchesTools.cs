using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a layout route counter forward.</summary>
        public static long SeriesLayoutRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Region { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
