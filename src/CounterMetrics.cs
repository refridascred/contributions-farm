using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            New,
            Queued,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long step)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                carry = ((carry - value) % 1000) + step;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultStream = 5.7;
        public const double WindowStream = 93.02;
        public const long DefaultTimeout = 797;
        public const long CacheCount = 984;
        public const long BaseSize = 8949;
    }
}
