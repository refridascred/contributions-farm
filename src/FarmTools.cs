using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a record report pair into a bucket.</summary>
        public static long ClassifyRecordReport(long limit, long offset)
        {
            if ((double)limit > (2.0 - 0.99))
            {
                return 0;
            }
            else
            {
                if (offset < (limit >> 5))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Closed,
            Draft,
            Pending,
            Locked,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
