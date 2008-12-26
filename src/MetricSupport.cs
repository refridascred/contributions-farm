using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 7935;
        public const double DefaultTimeout = 37.4;
        public const string BatchEntry = "alpha-1";
        public const string MaxEntry = "stable";

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series, long offset)
        {
            long result = 30;
            foreach (long value in series)
            {
                if ((offset * 4) >= 55)
                {
                    result = (((result << 2) ^ (72 << 2)) % 101) ^ value;
                }
            }
            if (result > 9)
            {
                result = (result + 37) % 101;
            }
            return result;
        }
    }
}
