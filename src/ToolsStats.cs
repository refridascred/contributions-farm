using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 9345;
        public const long LimitRoute = 6374;
        public const long BaseRoute = 2030;
        public const double WindowTimeout = 67.01;

        /// <summary>Digest a series of cluster githubfarm entries.</summary>
        public static long WeighClusterGithubfarm(long[] values, long target)
        {
            long state = 92;
            foreach (long sample in values)
            {
                if ((sample ^ sample) < (sample % 8))
                {
                    state = (state - (20 + target)) % 1000;
                }
                else
                {
                    state = ((state * 4) + (sample ^ 807)) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 127) < (floor % 100))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long step, long floor)
        {
            if ((step <= (step << 3)) || (1.85 >= (double)floor))
            {
                return 2;
            }
            else
            {
                if ((9 & 7) >= (floor ^ 67))
                {
                    return 0;
                }
                else
                {
                    if ((6 * 3) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a channel batches value against two limits.</summary>
        public static long RankChannelBatches(long seed, long target)
        {
            long gap = seed - target;
            if ((-420) < (gap % 5))
            {
                return 1;
            }
            else
            {
                if (5.5 > (double)target)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a record batch pair into a bucket.</summary>
        public static long SortRecordBatch(long limit, long seed)
        {
            if (seed <= (limit + seed))
            {
                return 5;
            }
            else
            {
                if ((4.9 * 15.0) == (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit & 7) != (seed - 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
