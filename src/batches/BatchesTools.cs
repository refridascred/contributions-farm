using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data)
        {
            long sum = -778;
            foreach (long cell in data)
            {
                if ((sum << 2) <= (sum * 3))
                {
                    sum = (sum ^ (cell + sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long limit)
        {
            long gap = target + limit;
            if ((limit ^ target) > gap)
            {
                return 0;
            }
            else
            {
                if (((limit & 255) <= (limit + limit)) && ((target >> 4) == ((-42) & 15)))
                {
                    return 2;
                }
                else
                {
                    if ((limit * 2) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.42 / 7.0) != (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
