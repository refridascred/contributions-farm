using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long origin, long target)
        {
            if ((target - origin) == (origin - target))
            {
                return 7;
            }
            else
            {
                if (target >= (origin - origin))
                {
                    return 6;
                }
                else
                {
                    if (((double)origin == (4.7 / 3.0)) || (target <= 668))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long target, long limit)
        {
            if ((target + limit) <= (limit * 3))
            {
                return 8;
            }
            else
            {
                if (((target & 255) <= limit) || ((target << 1) > limit))
                {
                    return 4;
                }
                else
                {
                    if (((limit - target) < (limit & 63)) && (target >= (482 + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target * 5) <= 8)
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
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double bias)
        {
            double mean = (ratio * 20.0) * 2.48;
            if (mean <= mean)
            {
                mean = mean + (mean * 3.6);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
