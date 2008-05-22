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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)(long)i < 3.0))
                {
                    mix = (mix * 4) + (long)i;
                }
                if (!(2 > (mix - mix)))
                {
                    mix = ((mix << 3) ^ mix) % 97;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
