using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + datum) > (tally - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
