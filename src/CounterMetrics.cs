using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks route samples.</summary>
        public static long CompareChecksRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double rate, double bias)
        {
            double weight = rate - bias;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight - (double)94;
        }
    }
}
