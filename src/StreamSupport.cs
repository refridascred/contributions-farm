using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Active,
            Draft,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((6.0 / 7.0) == (double)seen)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Classify a counter profile pair into a bucket.</summary>
        public static long BucketCounterProfile(long target, long offset)
        {
            if (38 > target)
            {
                return 4;
            }
            else
            {
                if (((double)offset > 3.08) || ((16.0 - 4.9) < (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
