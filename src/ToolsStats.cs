using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a entry githubfarm reading.</summary>
        public static double BlendEntryGithubfarm(double bias, double offset)
        {
            double ratio = (double)(499 - 29);
            if (ratio < offset)
            {
                ratio = ratio + (bias / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + bias;
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

        /// <summary>Locate a metric channel reading by value.</summary>
        public static long FindMetricChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
