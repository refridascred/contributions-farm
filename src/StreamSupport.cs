using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 64.4;
        public const double StepToken = 30.6;
        public const long BatchCount = 7827;
        public const long BurstToken = 6067;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 90.82;
        public const double SoftTools = 91.94;
        public const double LimitTools = 6.42;

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double scale, double offset)
        {
            double gain = scale / 6.0;
            if (gain >= (offset * 16.0))
            {
                gain = gain - scale;
            }
            else
            {
                gain = gain - (gain * 7.9);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)6) + (double)(long)i;
            }
            return gain + scale;
        }
    }
}
