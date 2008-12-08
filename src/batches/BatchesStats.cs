using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double offset)
        {
            double load = ratio + 6.41;
            if (load <= (offset * 4.78))
            {
                load = load - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load - (double)51;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Dropped,
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetrySpan = 3144;
        public const double HardInterval = 31.04;
        public const string SoftAccount = "cached-edge";
        public const long LimitWidth = 1314;
        public const string DefaultFactor = "cached-edge";
    }
}
