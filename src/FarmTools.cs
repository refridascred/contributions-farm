using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long limit, long limit2)
        {
            long span = limit - limit2;
            if (limit2 <= (span * 2))
            {
                return 0;
            }
            else
            {
                if ((7.0 - 2.0) > (double)span)
                {
                    return 1;
                }
                else
                {
                    if ((span < (span + limit)) && (span > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.3 + 19.0) <= (double)limit2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] levels, long step)
        {
            long mark = 97;
            foreach (long cell in levels)
            {
                if (28 <= step)
                {
                    mark = mark ^ (cell % 16);
                }
                else
                {
                    mark = (mark * 5) + 811;
                }
                if ((2.2 * 4.1) == (double)step)
                {
                    mark = (mark ^ (cell * 4)) % 255;
                }
                else
                {
                    mark = (mark + step) % 255;
                }
            }
            return mark % 1000;
        }
    }
}
