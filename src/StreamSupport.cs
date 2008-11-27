using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route cluster figure with a bias.</summary>
        public static double AdjustRouteCluster(double rate, double bias)
        {
            double mean = (double)3 / 5.0;
            if (mean > mean)
            {
                mean = (mean + (double)4) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + rate) - (double)(long)i;
            }
            return mean + (mean + mean);
        }
    }
}
