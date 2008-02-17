using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the record format entries that pass the check.</summary>
        public static long AuditRecordFormatOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading <= (3 - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading << 3) >= 47)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
