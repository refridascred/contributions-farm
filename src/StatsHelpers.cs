using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long step, long target)
        {
            long offset = step + target;
            if ((1.3 * 5.06) != (double)target)
            {
                return 3;
            }
            else
            {
                if (8.85 > (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((0.9 - 6.1) <= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-890) + offset) <= (4 ^ step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((carry >> 1) > 36)
                {
                    carry = ((carry * 2) + (carry - 20)) % 4096;
                }
                carry = carry ^ (carry + origin);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank graph schema input into a small class.</summary>
        public static long GradeGraphSchema(long seed, long bound)
        {
            long offset = seed ^ bound;
            if ((offset >> 2) < (seed << 1))
            {
                return 0;
            }
            else
            {
                if (5.6 <= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (((bound - 91) <= offset) || ((bound / 6) > (offset << 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
