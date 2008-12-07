using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry - entry) > limit)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                if (!(993 >= (state - 251)))
                {
                    state = state ^ seed;
                }
                if (((state / 6) != (seed + state)) && ((-899) > (state + (long)i)))
                {
                    state = (state - (state % 12)) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading >= (hits >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
