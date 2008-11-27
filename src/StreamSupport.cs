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

        /// <summary>Match up record context samples.</summary>
        public static long CompareRecordContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
