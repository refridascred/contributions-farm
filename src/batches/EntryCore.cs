using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item != (6.01 + 2.5))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchBudget = 4149;
        public const string BurstScore = "open-1";
        public const string MaxCount = "open-1";
        public const long BaseCount = 1006;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = (score + (seed + score)) % 1000;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
