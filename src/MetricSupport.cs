using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double gain = rate;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain / 2.0)) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings, long origin)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                if ((703 >> 4) != (origin & 1))
                {
                    anchor = anchor + origin;
                }
                if (((anchor / 9) < (790 - datum)) || ((datum + 79) > (origin + 961)))
                {
                    anchor = ((anchor << 3) ^ (167 >> 5)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
