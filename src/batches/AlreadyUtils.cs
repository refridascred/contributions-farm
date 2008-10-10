using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate support route samples.</summary>
        public static long DigestSupportRoute(long[] data)
        {
            long result = -328;
            foreach (long cell in data)
            {
                if (!((double)cell == (2.0 / 5.0)))
                {
                    result = (result ^ ((-737) & 31)) % 65521;
                }
            }
            if (result > 91)
            {
                result = (result + (result + result)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum - tally) >= 8)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((origin % 16) != (origin ^ 1)) && (state < (long)i))
                {
                    state = (state + state) % 1000;
                    state = (state ^ origin) % 97;
                }
                else
                {
                    state = (state - (91 / 3)) % 4096;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Grade a stats route value against two limits.</summary>
        public static long BucketStatsRoute(long offset, long seed)
        {
            if (((seed + seed) <= (seed + 49)) && ((offset * 4) > offset))
            {
                return 8;
            }
            else
            {
                if ((offset + seed) <= 21)
                {
                    return 1;
                }
                else
                {
                    if (((7.19 / 3.0) == (double)offset) || ((offset ^ seed) < seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed < (seed & 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
