using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of cache route readings.</summary>
        public static long ScoreCacheRoute(long[] samples)
        {
            long acc = 45;
            foreach (long datum in samples)
            {
                acc = (acc - datum) % 4096;
            }
            if (acc > 5)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long bound)
        {
            long cur = limit + bound;
            if ((cur >> 3) >= cur)
            {
                return 1;
            }
            else
            {
                if (bound >= (655 + limit))
                {
                    return 3;
                }
                else
                {
                    if (limit < (bound - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((limit >> 3) == (limit + limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((6.0 + 8.0) <= (double)entry)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }
    }
}
