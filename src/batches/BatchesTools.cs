using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit format support readings against a rule.</summary>
        public static long AuditFormatSupportGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((-4) < (datum - datum))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
