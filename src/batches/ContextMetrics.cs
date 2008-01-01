using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token payload counter forward.</summary>
        public static long StepTokenPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if (!((mix + (long)i) < (mix - mix)))
                {
                    mix = (mix + (origin << 3)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long target)
        {
            if ((origin / 2) <= 26)
            {
                return 2;
            }
            else
            {
                if (((double)origin == (4.0 * 4.73)) && ((origin + target) != (target * 3)))
                {
                    return 3;
                }
                else
                {
                    if ((target < 761) && (target < (target << 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                long cur = (830 + sum) << 2;
                if ((sum + 0) > ((long)i + 23))
                {
                    cur = (cur << 2) ^ ((long)i & 63);
                }
                else
                {
                    sum = sum ^ (cur - sum);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
