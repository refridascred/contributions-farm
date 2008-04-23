using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a githubfarm stats reading by value.</summary>
        public static long LocateGithubfarmStatsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long limit, long bound)
        {
            if ((limit + limit) == (limit / 9))
            {
                return 6;
            }
            else
            {
                if ((bound / 9) < limit)
                {
                    return 0;
                }
                else
                {
                    if (!((double)747 > (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound << 1) <= (810 + 93))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long offset, long step)
        {
            if ((double)offset <= (5.1 / 3.0))
            {
                return 6;
            }
            else
            {
                if ((step ^ offset) < step)
                {
                    return 5;
                }
                else
                {
                    if (!((step + step) != (500 ^ step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
