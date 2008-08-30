using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first tools account entry that matches the target.</summary>
        public static long FindToolsAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account notes readings against a rule.</summary>
        public static long CountAccountNotesGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value >> 4) == (tally % 24)) && (((2 + tally) >= target) && ((15.0 / 6.0) == (double)target)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((entry / 4) > (entry / 6)) || ((tally * 2) <= ((-608) + entry))) || ((double)tally >= (4.14 + 6.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
