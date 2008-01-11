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

        /// <summary>Check that every batch already entry stays within the limit.</summary>
        public static bool CheckBatchAlreadyLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
