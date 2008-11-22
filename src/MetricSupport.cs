using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two token editor measurements.</summary>
        public static double AdjustTokenEditor(double scale, double offset)
        {
            double gain = scale + offset;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (5.4 * 8.2)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
