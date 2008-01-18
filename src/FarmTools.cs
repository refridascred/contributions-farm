using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a counter tools reading.</summary>
        public static double SmoothCounterTools(double weight, double offset)
        {
            double weight2 = offset;
            return weight2 + weight;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double scale, double offset)
        {
            double mean = (offset / 7.0) / 9.0;
            if (mean > offset)
            {
                mean = mean + (offset - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (7.53 - scale)) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
