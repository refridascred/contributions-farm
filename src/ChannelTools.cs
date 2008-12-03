using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a metrics metric reading by value.</summary>
        public static long SeekMetricsMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account payload figure with a bias.</summary>
        public static double AdjustAccountPayload(double bias, double span)
        {
            double bias2 = (double)(7 - 98);
            if (bias2 <= (bias2 + bias))
            {
                bias2 = bias2 + (bias - span);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias) - (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
