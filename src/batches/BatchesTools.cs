using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)matches > (6.71 - 7.16)) || ((sample & 15) >= (-425)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((-97) >= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
