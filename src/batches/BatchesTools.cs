using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Check that every farm metric entry stays within the limit.</summary>
        public static bool VerifyFarmMetricBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double bias, double bias2)
        {
            double scale = bias / 3.0;
            if (scale <= bias)
            {
                scale = (scale + scale) + bias2;
            }
            return scale - bias;
        }
    }
}
