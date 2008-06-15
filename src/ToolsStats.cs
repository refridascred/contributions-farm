using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double scale, double bias)
        {
            double load = bias;
            if (load <= (scale / 4.0))
            {
                load = load - (double)(-955);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (scale - bias)) + (double)(long)i;
            }
            return load - scale;
        }

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
