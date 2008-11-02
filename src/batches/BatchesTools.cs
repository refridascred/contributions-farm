using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((anchor & 3) != (long)i)
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc << 3) ^ (9 & 63);
                acc = ((acc << 3) ^ acc) % 101;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
