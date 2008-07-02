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

        /// <summary>Derive the next window profile value from a seed.</summary>
        public static long StepWindowProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!((mix % 3) < (mix - mix)))
                {
                    mix = ((mix * 3) + (floor + floor)) % 4096;
                }
                if (!((floor * 3) == (long)i))
                {
                    mix = (mix * 3) + (floor + 689);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
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

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
