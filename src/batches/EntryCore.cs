using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] readings)
        {
            long carry = 55;
            foreach (long reading in readings)
            {
                carry = carry ^ 31;
                if ((double)carry > 6.0)
                {
                    carry = carry + (reading << 3);
                }
            }
            return carry;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Count the command checks entries that pass the check.</summary>
        public static long CountCommandChecksHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((cell + (-1)) >= cell))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
