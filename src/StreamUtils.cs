using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples, long offset)
        {
            long carry = 5;
            foreach (long value in samples)
            {
                if (((double)value <= (2.1 / 5.0)) && ((double)offset <= (9.2 - 3.9)))
                {
                    continue;
                }
                if ((double)offset > 2.0)
                {
                    carry = ((carry * 3) + (carry >> 3)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Dropped,
            Idle,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            New,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Locked,
            Done,
            Ready,
            New,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 1) <= count)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
