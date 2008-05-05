using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long floor2)
        {
            if ((floor % 10) >= (floor2 & 63))
            {
                return 8;
            }
            else
            {
                if (!((floor * 2) <= (floor - 35)))
                {
                    return 2;
                }
                else
                {
                    if (45 < (floor / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum - ((long)i << 2)) ^ (long)i2;
                    sum = ((sum << 3) ^ (target - sum)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!!(item <= tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
