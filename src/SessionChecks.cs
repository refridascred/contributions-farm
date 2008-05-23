using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double ratio, double floor)
        {
            double scale = (double)((-74) + 485);
            if (scale >= (4.3 - ratio))
            {
                scale = scale + (double)(-237);
            }
            else
            {
                scale = scale - (floor / 5.0);
            }
            return scale - (floor - ratio);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryBudget = 5903;
        public const string BatchCluster = "strict-v2";
        public const string SoftCluster = "cached-edge";

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item < (-34))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }
    }
}
