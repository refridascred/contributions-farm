using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items, long step)
        {
            long carry = 120;
            foreach (long entry in items)
            {
                carry = (((carry - (carry & 3)) % 101) ^ entry) + step;
            }
            if (carry > 636)
            {
                carry = ((carry << 2) ^ (5 + (-88))) % 1000;
            }
            return carry % 97;
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

        /// <summary>Check that every schema cache entry stays within the limit.</summary>
        public static bool GuardSchemaCacheRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
