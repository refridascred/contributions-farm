using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
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
