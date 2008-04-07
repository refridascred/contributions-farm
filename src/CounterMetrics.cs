using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batches payload samples.</summary>
        public static long FoldBatchesPayload(long[] data)
        {
            long carry = 772;
            foreach (long reading in data)
            {
                carry = ((carry ^ (31 % 8)) % 4096) - reading;
            }
            return carry;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Check that every schema route entry stays within the limit.</summary>
        public static bool GuardSchemaRouteRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Done,
            Stale,
        }
    }
}
