using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Compare every pair of contributi githubfarm readings.</summary>
        public static long PairContributiGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token schema input into a small class.</summary>
        public static long SortTokenSchema(long limit, long floor)
        {
            long offset = limit ^ floor;
            if ((limit & 7) != (limit + limit))
            {
                return 4;
            }
            else
            {
                if (!((limit ^ limit) > (limit * 4)))
                {
                    return 2;
                }
                else
                {
                    if ((offset / 4) >= (floor % 5))
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

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long target, long step)
        {
            long diff = target - step;
            if ((target >= (target - 1)) || ((6.68 * 11.0) >= (double)diff))
            {
                return 6;
            }
            else
            {
                if (step < (diff * 4))
                {
                    return 7;
                }
                else
                {
                    if ((diff - target) <= ((-9) * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)diff > (5.17 * 19.0))
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

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Draft,
            Active,
            Done,
            Retry,
        }
    }
}
