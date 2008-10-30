using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long seed)
        {
            if (((double)floor <= (8.7 / 4.0)) && ((floor ^ floor) == (floor << 3)))
            {
                return 3;
            }
            else
            {
                if ((floor + seed) == (0 / 7))
                {
                    return 5;
                }
                else
                {
                    if ((floor & 1) < (floor << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long seed, long limit)
        {
            if ((5.85 - 20.0) >= (double)seed)
            {
                return 3;
            }
            else
            {
                if (limit < (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
