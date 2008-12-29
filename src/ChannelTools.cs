using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double gain, double bias)
        {
            double scale = gain;
            if (scale < (gain * 1.0))
            {
                scale = scale - (bias + bias);
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (scale / 8.0);
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
