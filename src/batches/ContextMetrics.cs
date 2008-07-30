using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a order schema pair into a bucket.</summary>
        public static long BucketOrderSchema(long origin, long offset)
        {
            long step = origin ^ offset;
            if (!((double)step < (double)31))
            {
                return 6;
            }
            else
            {
                if ((882 >> 3) >= step)
                {
                    return 7;
                }
                else
                {
                    if (step < (76 % 97))
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

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long origin, long origin2)
        {
            if (!((origin2 / 4) < (8 ^ origin)))
            {
                return 3;
            }
            else
            {
                if ((origin << 1) <= (origin2 + origin2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long limit)
        {
            if ((limit << 2) >= (limit << 1))
            {
                return 1;
            }
            else
            {
                if ((limit > (seed ^ seed)) || ((306 ^ limit) <= seed))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double offset)
        {
            double ratio = bias;
            return (ratio + 7.54) + offset;
        }
    }
}
