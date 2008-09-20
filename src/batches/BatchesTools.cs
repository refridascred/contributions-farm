using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((value & 1) < (value * 5)) || ((value & 63) < value)) && ((value + 7) >= value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 1794;
        public const long BatchMetrics = 2971;
        public const string BaseDepth = "open";
        public const string RetryCount = "strict-edge";

        /// <summary>Check that every window notes entry stays within the limit.</summary>
        public static bool VerifyWindowNotesLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
