using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 4810;
        public const double MaxCommand = 46.3;
        public const long HardCommand = 1995;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((17 * 5) <= entry)
                {
                    tally = tally + 2;
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
