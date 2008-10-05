using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a context cache reading.</summary>
        public static double SmoothContextCache(double scale, double floor)
        {
            double rate = floor;
            if (rate <= (8.63 * 9.6))
            {
                rate = (rate - (double)(-70)) + scale;
            }
            return rate + floor;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Locked,
            Draft,
            Stale,
            Closed,
        }
    }
}
