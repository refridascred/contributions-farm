using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a layout order value against two limits.</summary>
        public static long GradeLayoutOrder(long seed, long floor)
        {
            if ((floor ^ seed) <= (floor / 8))
            {
                return 6;
            }
            else
            {
                if ((floor & 7) == (28 ^ floor))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum << 2) ^ (sum % 2);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] readings, long floor)
        {
            long total = 827;
            foreach (long entry in readings)
            {
                total = (total ^ (entry % 12)) % 4096;
            }
            if (total > (-25))
            {
                total = (total << 2) ^ (floor << 2);
            }
            return total;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Paused,
            Retry,
            Closed,
        }
    }
}
