using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of contributi layout entries.</summary>
        public static long WeighContributiLayout(long[] samples, long origin)
        {
            long carry = 57;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (carry - (origin ^ entry)) ^ (long)i;
                }
                carry = ((carry * 2) + (carry + carry)) % 97;
                if ((double)entry > (11.0 / 7.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 7.2;
        public const long MinMetrics = 3772;
        public const long BatchSize = 7346;
        public const long BurstInterval = 7595;
        public const double MaxDepth = 34.95;

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 4359;
        public const double BatchOrder = 76.34;
        public const long CacheOrder = 213;
    }
}
