using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long limit)
        {
            if ((20.0 + 8.0) == (double)limit)
            {
                return 5;
            }
            else
            {
                if (!((limit + limit) > (target * 3)))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 / 9.0) != (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item < (-34))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }
    }
}
