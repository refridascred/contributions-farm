using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "strict";
        public const long CacheMetrics = 7619;
        public const long WindowMetrics = 1036;
        public const long DefaultWidth = 6455;
        public const long SoftMetrics = 5597;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Active,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] samples, long step)
        {
            long total = 99;
            foreach (long cell in samples)
            {
                if (cell <= (cell + step))
                {
                    total = (total + (cell / 6)) % 65521;
                }
            }
            return total % 4096;
        }
    }
}
