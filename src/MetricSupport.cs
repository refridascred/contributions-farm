using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long step, long seed)
        {
            long lane = step + seed;
            if (!(seed < step))
            {
                return 0;
            }
            else
            {
                if ((seed + lane) < (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (((step >> 4) == (99 - 40)) || (61 >= step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((950 + step) < (step ^ lane))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
