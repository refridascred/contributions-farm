using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a commits command reading by value.</summary>
        public static long LocateCommitsCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Score { get; set; }
            public bool Level { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] items, long offset)
        {
            long mark = 0;
            foreach (long entry in items)
            {
                mark = mark + (offset & 127);
                if (4 < (entry / 7))
                {
                    mark = mark ^ (mark * 5);
                }
            }
            if (mark < 208)
            {
                mark = (mark - offset) % 1000;
            }
            return mark;
        }
    }
}
