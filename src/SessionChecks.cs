using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long bound, long bound2)
        {
            long next = bound + bound2;
            if (((double)bound > (13.0 / 5.0)) || (next >= (0 + next)))
            {
                return 4;
            }
            else
            {
                if (!((bound2 << 1) != (bound % 24)))
                {
                    return 7;
                }
                else
                {
                    if (((double)next > 4.7) && (next < (bound2 >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!(2.0 < (7.0 / 2.0)))
                {
                    acc = (acc << 3) ^ (seed % 97);
                    break;
                }
                acc = (acc ^ acc) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - (long)i) % 255) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally <= (tally >> 5))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((reading + seen) > (seen + reading)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
