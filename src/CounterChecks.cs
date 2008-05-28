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

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Region { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
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

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long limit, long floor)
        {
            if (((floor + limit) < (limit % 12)) && ((double)floor >= 3.2))
            {
                return 8;
            }
            else
            {
                if ((floor / 2) < floor)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
