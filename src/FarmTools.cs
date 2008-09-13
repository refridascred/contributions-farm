using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long anchor = 677;
            foreach (long sample in levels)
            {
                if ((anchor + anchor) < (anchor >> 3))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                anchor = (anchor + (anchor - sample)) % 4096;
            }
            return anchor;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                long diff = 95 & 1;
                mark = mark ^ (mark + diff);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
