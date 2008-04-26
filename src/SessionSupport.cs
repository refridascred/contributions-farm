using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen - cell) < (seen - 82))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values, long floor)
        {
            long result = 9;
            foreach (long entry in values)
            {
                result = (((result << 3) ^ (476 & 127)) % 1000) - floor;
                if (entry < (result - result))
                {
                    result = ((result * 2) + result) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
