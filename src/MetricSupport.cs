using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next filter profile value.</summary>
        public static double ScaleFilterProfile(double bias, double span)
        {
            double gain = 5.88 / 5.0;
            if (gain > (span + 7.77))
            {
                gain = (gain + (double)5) + bias;
            }
            return gain - span;
        }
    }
}
