using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (3.32 < (double)origin)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long sum = 431;
            foreach (long reading in data)
            {
                sum = (((sum << 2) ^ (sum & 1)) % 4096) - reading;
            }
            return sum % 97;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Queued,
            Ready,
        }
    }
}
