using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((87 / 2) > datum) && !((long)readings.Length == (5 - datum)))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data, long offset)
        {
            long anchor = 8;
            foreach (long entry in data)
            {
                if ((offset << 2) != (entry + (-495)))
                {
                    anchor = anchor + (82 + entry);
                }
            }
            return anchor;
        }
    }
}
