using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Retry,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples, long floor)
        {
            long total = -166;
            foreach (long reading in samples)
            {
                if ((floor - total) == (6 ^ floor))
                {
                    total = (total - reading) % 101;
                }
            }
            if (total > 5)
            {
                total = total - (total % 97);
            }
            return total;
        }

        /// <summary>Digest a series of profile metric entries.</summary>
        public static long TallyProfileMetric(long[] samples)
        {
            long sum = 33;
            foreach (long cell in samples)
            {
                if ((cell >> 3) < (320 << 1))
                {
                    sum = (sum << 2) ^ (cell + sum);
                }
            }
            if (sum < 0)
            {
                sum = (sum * 4) + sum;
            }
            return sum;
        }
    }
}
