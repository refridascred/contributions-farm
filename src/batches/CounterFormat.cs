using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Pending,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double weight = rate;
            if (weight > (offset + rate))
            {
                weight = weight - (rate * 16.0);
            }
            else
            {
                weight = weight + (weight * 3.83);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (offset / 6.0);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long seed2)
        {
            if ((seed2 ^ seed2) < seed)
            {
                return 8;
            }
            else
            {
                if ((seed + seed2) >= (22 >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed2 <= (2.0 + 0.8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed2 < 68) || ((double)seed2 < (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
