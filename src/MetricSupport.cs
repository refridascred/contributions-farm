using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] samples, long step)
        {
            long result = 86;
            foreach (long cell in samples)
            {
                result = (((result ^ result) % 255) ^ cell) + step;
            }
            if (result < 3)
            {
                result = (result + (long)samples.Length) % 1000;
            }
            return result;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double weight, double span)
        {
            double scale = weight;
            if (scale < 0.6)
            {
                scale = scale + (double)800;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 2.11) + (double)(long)i;
            }
            return scale - (weight - span);
        }
    }
}
