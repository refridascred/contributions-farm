using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum ^ (sum / 4)) % 4096;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long floor, long origin)
        {
            if (origin < (origin / 5))
            {
                return 4;
            }
            else
            {
                if ((floor & 255) != (origin << 3))
                {
                    return 7;
                }
                else
                {
                    if ((floor / 7) <= (floor >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Failed,
            Retry,
        }
    }
}
