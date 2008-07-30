using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches - matches) > matches)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }
    }
}
