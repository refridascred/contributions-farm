using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Dropped,
            Ready,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 8763;
        public const long WindowRecord = 8256;
        public const string SoftRecord = "open-1";

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series)
        {
            long carry = 817;
            foreach (long datum in series)
            {
                carry = ((carry << 2) ^ (datum << 2)) % 101;
            }
            return carry;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double ratio, double floor)
        {
            double gain = (ratio - ratio) + floor;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (floor * 4.1)) + (double)(long)i;
            }
            return gain + (double)39;
        }
    }
}
