using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            New,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = 122;
            foreach (long cell in items)
            {
                if ((double)cell > (18.0 / 9.0))
                {
                    anchor = (anchor + (779 + cell)) % 65521;
                }
                else
                {
                    anchor = (anchor - anchor) % 1000;
                }
                if ((anchor - cell) >= (38 & 31))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Token { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
