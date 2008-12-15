using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the report context entries that pass the check.</summary>
        public static long CountReportContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((7.74 - 2.0) != (double)cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
