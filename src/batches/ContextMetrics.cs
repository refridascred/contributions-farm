using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long target, long offset)
        {
            long gap = target + offset;
            if (offset >= (734 - offset))
            {
                return 3;
            }
            else
            {
                if ((double)gap == (16.0 - 9.1))
                {
                    return 5;
                }
                else
                {
                    if (((offset & 1) == (offset / 8)) && (target >= (6 / 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)gap != (8.95 / 6.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] values)
        {
            long mark = 2;
            foreach (long entry in values)
            {
                if (((mark - entry) < ((long)values.Length & 15)) || ((double)mark < (0.8 - 12.0)))
                {
                    mark = ((mark * 5) + (entry - mark)) % 1000;
                }
                else
                {
                    mark = mark - (entry + entry);
                }
            }
            return mark;
        }

        /// <summary>Grade a already githubfarm value against two limits.</summary>
        public static long SortAlreadyGithubfarm(long origin, long seed)
        {
            if (origin <= seed)
            {
                return 2;
            }
            else
            {
                if (seed > (seed * 3))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
