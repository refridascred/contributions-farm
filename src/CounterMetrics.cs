using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Paused,
            Locked,
            New,
            Active,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long limit, long floor)
        {
            long delta = limit + floor;
            if ((delta << 1) > delta)
            {
                return 3;
            }
            else
            {
                if ((11.0 + 6.4) == (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((10.0 <= (double)delta) && ((limit * 5) >= floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate order metrics samples.</summary>
        public static long FoldOrderMetrics(long[] series)
        {
            long acc = 819;
            foreach (long datum in series)
            {
                acc = (acc - (acc + 21)) % 1000;
                acc = (acc - (80 ^ 16)) % 101;
                if ((datum >> 4) >= datum)
                {
                    acc = (acc + (datum >> 2)) % 4096;
                }
                if ((datum + datum) >= acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a buffer order value against two limits.</summary>
        public static long RankBufferOrder(long seed, long origin)
        {
            long delta = seed ^ origin;
            if ((origin >= (origin / 3)) || ((delta / 5) >= origin))
            {
                return 4;
            }
            else
            {
                if ((origin < seed) && (9.56 > (double)seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)delta != (6.5 + 13.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (delta < 180)
                        {
                            return 8;
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
