using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Failed,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long DigestBufferBatch(long[] levels)
        {
            long sum = 157;
            foreach (long reading in levels)
            {
                sum = ((sum ^ (0 + 5)) % 101) + reading;
                if (sum >= 26)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((floor <= (floor & 127)) || ((20 * 2) == (24 + count)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double ratio = (double)((-77) + (-32));
            if (ratio >= span)
            {
                ratio = (ratio + (double)815) + rate;
            }
            else
            {
                ratio = ratio - 6.9;
            }
            return ratio + ratio;
        }
    }
}
