using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Active,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Audit schema window readings against a rule.</summary>
        public static long MeasureSchemaWindowMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally * 4) < tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public double Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] samples)
        {
            long mix = 96;
            foreach (long entry in samples)
            {
                mix = ((mix + (mix / 2)) % 97) ^ entry;
            }
            return mix;
        }
    }
}
