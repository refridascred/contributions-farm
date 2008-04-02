using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = mix - (offset >> 3);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double scale2 = scale + offset;
            if (scale2 >= 0.31)
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (scale2 / 6.0)) + (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Done,
            Idle,
            Pending,
        }
    }
}
