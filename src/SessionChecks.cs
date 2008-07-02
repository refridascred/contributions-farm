using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the account cache series from a seed.</summary>
        public static long SeriesAccountCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long seed, long floor)
        {
            long next = seed - floor;
            if (((double)next != (double)floor) && ((next * 2) != (floor % 64)))
            {
                return 4;
            }
            else
            {
                if (seed < (next << 1))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((bound / 2) != (bound * 4)) || (((tally + (-46)) <= (bound / 3)) && (tally >= (value % 10))))
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

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 1209;
        public const long BatchWidth = 783;
        public const double WindowSession = 44.31;
    }
}
