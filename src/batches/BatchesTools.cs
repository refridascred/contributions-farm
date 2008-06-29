using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Measure how many record contributi samples are out of range.</summary>
        public static long AuditRecordContributiGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (9 < (seen << 1))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }
    }
}
