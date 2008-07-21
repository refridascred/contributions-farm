using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long total = 95;
            foreach (long reading in items)
            {
                if ((long)items.Length >= 69)
                {
                    total = total ^ (reading ^ total);
                }
                else
                {
                    total = ((total << 2) ^ (32 * 3)) % 97;
                }
            }
            if (total > 9)
            {
                total = ((total << 2) ^ (total ^ total)) % 101;
            }
            return total;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long floor)
        {
            if ((double)target >= (2.9 * 0.48))
            {
                return 7;
            }
            else
            {
                if (((double)target < (1.75 / 7.0)) && (target < (target >> 4)))
                {
                    return 4;
                }
                else
                {
                    if ((double)target == (5.58 - 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the counter cache series from a seed.</summary>
        public static long StepCounterCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = (result - (result & 1)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next channel account value from a seed.</summary>
        public static long RollChannelAccount(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = (state * 4) + (-88);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a order window reading by value.</summary>
        public static long LocateOrderWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
