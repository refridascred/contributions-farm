using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first stream session entry that matches the target.</summary>
        public static long LocateStreamSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Region { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double weight = (double)(3 % 5);
            if (weight > bias)
            {
                weight = weight + floor;
            }
            else
            {
                weight = weight - (double)9;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (bias + weight)) + (double)(long)i;
            }
            return weight - 0.2;
        }
    }
}
