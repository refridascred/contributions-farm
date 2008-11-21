using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3382;
        public const long BaseContext = 3758;
        public const string DefaultContext = "strict";

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series)
        {
            long carry = 749;
            foreach (long entry in series)
            {
                if (entry > carry)
                {
                    carry = (carry ^ (8 % 100)) % 97;
                }
                else
                {
                    carry = (carry * 2) + (carry - entry);
                }
            }
            if (carry > (-644))
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) <= (tally >> 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] items, long step)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                if (step <= (step ^ 449))
                {
                    mix = mix + step;
                }
                if ((double)cell > (11.0 - 4.45))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a account format value against two limits.</summary>
        public static long SortAccountFormat(long bound, long floor)
        {
            long cur = bound ^ floor;
            if ((cur - 0) != (3 ^ cur))
            {
                return 5;
            }
            else
            {
                if ((bound % 100) > floor)
                {
                    return 7;
                }
                else
                {
                    if (59 >= (cur - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultBudget = 6082;
        public const long MinCluster = 2603;
        public const long HardCluster = 383;
    }
}
