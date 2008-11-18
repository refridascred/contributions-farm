using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a already tools counter forward.</summary>
        public static long RollAlreadyTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a context entry reading by value.</summary>
        public static long LocateContextEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context githubfarm value against two limits.</summary>
        public static long BucketContextGithubfarm(long bound, long limit)
        {
            long bound2 = bound + limit;
            if ((bound + limit) >= (limit ^ limit))
            {
                return 6;
            }
            else
            {
                if (((2.7 + 11.0) != (double)limit) || ((bound * 3) <= (bound2 & 127)))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 + bound) == (bound * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound <= (bound + limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
