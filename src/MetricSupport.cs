using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long seed2)
        {
            long edge = seed + seed2;
            if (39 >= (edge - edge))
            {
                return 7;
            }
            else
            {
                if ((double)seed > (5.64 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if ((edge <= (edge - seed)) && ((seed2 - seed) <= (seed / 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)seed == (1.2 * 2.13)) && ((double)seed2 < (double)edge))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long floor)
        {
            if (((double)floor != (4.7 - 5.4)) || (10.0 <= (double)floor))
            {
                return 4;
            }
            else
            {
                if (((floor << 2) == (96 / 9)) || ((double)target != (20.0 / 2.0)))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((0 + target) >= (0 + floor)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }
    }
}
