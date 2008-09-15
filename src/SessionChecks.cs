using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of githubfarm batches readings.</summary>
        public static long OverlapGithubfarmBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long origin, long bound)
        {
            if (((double)origin >= (7.48 * 1.3)) && ((bound / 5) > (origin << 3)))
            {
                return 0;
            }
            else
            {
                if ((13 / 2) > bound)
                {
                    return 2;
                }
                else
                {
                    if (bound > (bound % 24))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + origin) <= (bound - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double scale = (rate - rate) / 6.0;
            if (scale >= (bias / 2.0))
            {
                scale = scale - (double)41;
            }
            else
            {
                scale = scale - (bias + rate);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (bias - scale);
        }
    }
}
