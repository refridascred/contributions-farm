using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long limit, long bound)
        {
            if (((double)limit != (double)bound) && ((3 ^ limit) >= (limit / 6)))
            {
                return 4;
            }
            else
            {
                if ((12.0 + 13.0) < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit < (9.97 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + limit) > (limit / 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long seed)
        {
            long prev = limit - seed;
            if (!((seed % 3) < (535 >> 4)))
            {
                return 7;
            }
            else
            {
                if ((limit << 3) != (prev * 2))
                {
                    return 4;
                }
                else
                {
                    if (prev >= (limit * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)prev == (1.0 - 4.9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format route readings against a rule.</summary>
        public static long MeasureFormatRouteGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((floor % 60) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Stale,
            Synced,
            Locked,
            Queued,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((627 + hits) < step)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
