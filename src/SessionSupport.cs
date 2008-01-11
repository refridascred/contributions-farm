using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + 248) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
