using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 698;
        public const string BatchCount = "latest";
        public const long BurstLayout = 7249;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Queued,
            Active,
            Done,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double span)
        {
            double scale2 = (7.0 * 11.0) + (span / 4.0);
            if (scale2 > 20.0)
            {
                scale2 = (scale2 + (double)89) + scale;
            }
            else
            {
                scale2 = scale2 - (double)19;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (scale2 / 8.0)) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}
