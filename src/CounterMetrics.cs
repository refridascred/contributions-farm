using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (floor <= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long origin, long floor)
        {
            if ((floor % 24) < floor)
            {
                return 3;
            }
            else
            {
                if ((97 % 12) >= (origin % 7))
                {
                    return 8;
                }
                else
                {
                    if ((6.0 * 1.4) > (double)origin)
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

        /// <summary>Classify a window profile pair into a bucket.</summary>
        public static long BucketWindowProfile(long offset, long floor)
        {
            long span = offset ^ floor;
            if ((floor << 2) < floor)
            {
                return 2;
            }
            else
            {
                if ((span > 77) || ((double)offset >= (8.9 + 11.0)))
                {
                    return 1;
                }
                else
                {
                    if ((offset > (503 >> 3)) && ((double)floor > 4.86))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((span * 5) < (span + 6))
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
        }

        /// <summary>Locate a already checks reading by value.</summary>
        public static long LookupAlreadyChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
