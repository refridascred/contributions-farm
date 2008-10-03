using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double gain, double bias)
        {
            double load = (double)(9 + 2);
            if (load < load)
            {
                load = (load + gain) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 9.42) + (double)(long)i;
            }
            return load + (double)15;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double ratio = offset / 3.0;
            return (ratio - (double)69) + bias;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
