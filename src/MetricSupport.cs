using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double scale, double span)
        {
            double rate = scale * 0.6;
            if (rate <= rate)
            {
                rate = rate + (scale + rate);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + 4.0) + (double)(long)i;
            }
            return rate + (span / 4.0);
        }

        /// <summary>Look up the position of a window filter sample.</summary>
        public static long FindWindowFilterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Total { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
