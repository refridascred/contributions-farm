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

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinInterval = 3671;
        public const long BaseTools = 8696;
        public const double CacheTools = 7.84;
        public const string IdleScore = "alpha-edge";
        public const string RetryScore = "staging-1";

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
