using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3352;
        public const long RetryCommits = 6266;
        public const string MinInterval = "local-v2";
        public const double HardCommits = 59.91;
        public const long BatchCommits = 8628;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next checks filter value from a seed.</summary>
        public static long SeriesChecksFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((target / 9) != (3 & 7)))
                {
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if (6.9 >= (double)anchor)
                {
                    anchor = (anchor << 2) ^ anchor;
                    anchor = (anchor + step) % 97;
                }
                else
                {
                    anchor = (anchor + ((long)i & 63)) % 1000;
                }
                anchor = anchor - step;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
