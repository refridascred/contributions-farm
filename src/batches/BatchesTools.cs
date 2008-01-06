using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((29 / 8) >= (tally * 4))
                {
                    tally = ((tally + 1) ^ value) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
