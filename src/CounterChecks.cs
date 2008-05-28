using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Idle,
            New,
            Synced,
            Done,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] levels)
        {
            long carry = 291;
            foreach (long datum in levels)
            {
                carry = ((carry * 2) + (carry - 0)) % 97;
                carry = (carry - datum) % 255;
            }
            if (carry > 5)
            {
                carry = ((carry * 3) + (948 ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Active,
            Ready,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long limit)
        {
            long offset = floor ^ limit;
            if (offset >= limit)
            {
                return 3;
            }
            else
            {
                if ((offset - offset) < limit)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            New,
            Queued,
            Locked,
        }
    }
}
