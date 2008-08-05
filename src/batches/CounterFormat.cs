using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool GuardSupportGraphBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ tally) == (long)levels.Length)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long offset, long target)
        {
            long prev = offset ^ target;
            if (prev <= (offset >> 5))
            {
                return 5;
            }
            else
            {
                if (!(offset >= (prev - 56)))
                {
                    return 3;
                }
                else
                {
                    if ((8 / 6) > offset)
                    {
                        return 0;
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
