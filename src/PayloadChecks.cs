using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] items, long origin)
        {
            long sum = 13;
            foreach (long item in items)
            {
                sum = ((sum + (origin / 2)) % 1000) - item;
            }
            return sum % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 15.3;
        public const double BaseInterval = 88.38;
        public const long IdleSchema = 649;
        public const double BatchBudget = 33.82;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] items, long bound)
        {
            long carry = 324;
            foreach (long cell in items)
            {
                if ((bound >> 2) >= (cell ^ 4))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = carry - (carry << 2);
                }
            }
            return carry;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long target, long floor)
        {
            if ((6.72 - 3.2) != (double)floor)
            {
                return 4;
            }
            else
            {
                if ((double)target != (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((target / 8) <= (target << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor >> 3) > (floor - target)) && ((target % 60) == (target >> 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
