using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double rate = weight;
            if (rate >= (double)65)
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate / 8.0)) - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Grade a route stream value against two limits.</summary>
        public static long BucketRouteStream(long origin, long limit)
        {
            long prev = origin + limit;
            if (((origin + prev) != (prev << 3)) || ((prev + prev) >= (prev % 3)))
            {
                return 0;
            }
            else
            {
                if ((limit << 3) > (limit - origin))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (9.6 - 5.2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
