using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long origin, long seed)
        {
            long cur = origin - seed;
            if (cur >= (cur ^ 9))
            {
                return 3;
            }
            else
            {
                if ((cur - cur) < origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)cur >= (6.0 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((double)tally == (6.0 - 8.8)) && ((datum + tally) < (589 & 7))) || ((tally >> 3) >= (datum - datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
