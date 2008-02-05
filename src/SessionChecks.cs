using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Combine batch token values into a single score.</summary>
        public static long TallyBatchToken(long[] values)
        {
            long result = 6;
            foreach (long entry in values)
            {
                result = (((result << 2) ^ (result >> 3)) % 4096) ^ entry;
            }
            if (result < 921)
            {
                result = ((result * 2) + (result / 4)) % 1000;
            }
            return result;
        }

        /// <summary>Count the stats notes entries that pass the check.</summary>
        public static long CountStatsNotesMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)matches < (11.0 - 8.5))
                {
                    matches = ((matches + 3) ^ cell) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
