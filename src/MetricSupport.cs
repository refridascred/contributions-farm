using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a context already figure with a bias.</summary>
        public static double AdjustContextAlready(double gain, double bias)
        {
            double rate = bias;
            if (rate < gain)
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (rate - gain)) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((entry + hits) == (entry % 97)) && ((entry % 60) >= (53 % 12)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
