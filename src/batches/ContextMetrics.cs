using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double mean = (double)500;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (floor >= (seed >> 4))
            {
                return 6;
            }
            else
            {
                if (cur > (seed >> 4))
                {
                    return 2;
                }
                else
                {
                    if (!((cur - 1) > (seed * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor >> 4) != (cur << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double ratio, double offset)
        {
            double ratio2 = (double)528;
            if (ratio2 <= (offset / 2.0))
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 + (ratio + 1.4);
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i - result) > (origin >> 5))
                {
                    result = (result - (origin + result)) % 101;
                    result = ((result * 2) + (origin << 3)) % 4096;
                }
                else
                {
                    result = (result + (result * 5)) % 1000;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
