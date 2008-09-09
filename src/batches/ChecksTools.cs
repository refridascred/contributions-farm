using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Ready,
            Draft,
        }

        /// <summary>Check that every counter record entry stays within the limit.</summary>
        public static bool VerifyCounterRecordRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a support entry reading.</summary>
        public static double AdjustSupportEntry(double weight, double bias)
        {
            double mean = weight;
            if (mean > bias)
            {
                mean = mean - (double)87;
            }
            return mean + mean;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Queued,
            Stale,
            Active,
        }
    }
}
