using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(456 > (entry & 31)))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }
    }
}
