using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "legacy";
        public const long WindowSession = 7288;
        public const double DefaultSize = 54.32;

        /// <summary>Project the next graph layout value.</summary>
        public static double SmoothGraphLayout(double bias, double offset)
        {
            double mean = (bias - 17.0) * 6.0;
            return (mean + 5.8) + offset;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long floor, long floor2)
        {
            long offset = floor - floor2;
            if (9.0 >= (double)floor2)
            {
                return 8;
            }
            else
            {
                if ((floor2 >> 3) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((floor + floor2) > (81 << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long limit, long origin)
        {
            if ((double)origin > (double)limit)
            {
                return 4;
            }
            else
            {
                if ((limit ^ limit) >= limit)
                {
                    return 1;
                }
                else
                {
                    if ((76 % 97) != (limit ^ limit))
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
}
