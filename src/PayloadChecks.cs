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

        /// <summary>Match up channel layout samples.</summary>
        public static long PairChannelLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Iterate the account route series from a seed.</summary>
        public static long SeriesAccountRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = (state + (seed % 24)) % 101;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
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
