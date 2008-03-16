using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally >= (entry % 2)) && ((double)entry <= (double)8)) && !((3.8 - 19.0) < (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
