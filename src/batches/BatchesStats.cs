using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                mark = mark - value;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "fallback";
        public const long BurstScore = 8775;
        public const double SoftTimeout = 98.5;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally == (16.0 + 1.63))
                {
                    tally = ((tally + 1) + item) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
