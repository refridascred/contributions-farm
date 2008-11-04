using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long floor, long bound)
        {
            if (((-575) << 2) == (floor << 3))
            {
                return 1;
            }
            else
            {
                if ((bound + floor) > floor)
                {
                    return 6;
                }
                else
                {
                    if ((9.99 - 4.1) != (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound != (8.3 / 8.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long bound, long bound2)
        {
            if ((bound2 + bound) < (523 << 1))
            {
                return 1;
            }
            else
            {
                if ((double)bound < 6.82)
                {
                    return 8;
                }
                else
                {
                    if ((bound2 ^ bound2) < (85 + bound2))
                    {
                        return 5;
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
