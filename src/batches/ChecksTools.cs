using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long seed)
        {
            long next = origin ^ seed;
            if ((next <= (next - origin)) || ((9 / 8) > (next - seed)))
            {
                return 8;
            }
            else
            {
                if ((seed - origin) != (93 * 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin <= (9.0 + 7.86))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.76 / 5.0) <= (double)next)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (seed * 4)) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the stream contributi entries that pass the check.</summary>
        public static long TallyStreamContributiHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((floor ^ seen) != (floor & 3))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
