using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] readings)
        {
            long sum = 265;
            foreach (long value in readings)
            {
                sum = (sum << 3) ^ (value + 5);
                if ((double)value < (6.7 * 14.0))
                {
                    sum = (sum << 2) ^ (1 - 6);
                }
                if ((double)sum != (4.0 / 8.0))
                {
                    sum = sum + 4;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Paused,
            Idle,
            Pending,
            Draft,
        }
    }
}
