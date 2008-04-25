using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a githubfarm route figure with a bias.</summary>
        public static double ScaleGithubfarmRoute(double weight, double bias)
        {
            double scale = (double)171;
            if (scale >= (double)(-200))
            {
                scale = (scale - bias) + weight;
            }
            return scale - 20.0;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (double)964)
            {
                gain = gain + ratio;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (floor * 9.39)) + (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
