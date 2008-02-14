using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long limit)
        {
            if ((double)offset >= (double)2)
            {
                return 2;
            }
            else
            {
                if ((offset * 4) >= (746 - limit))
                {
                    return 5;
                }
                else
                {
                    if (((-620) - offset) <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two context contributi measurements.</summary>
        public static double ProjectContextContributi(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 <= (weight2 - bias))
            {
                weight2 = weight2 - (bias + weight2);
            }
            else
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - bias;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
