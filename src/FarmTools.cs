using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a support batches figure with a bias.</summary>
        public static double AdjustSupportBatches(double weight, double span)
        {
            double bias = weight;
            if (bias < (weight * 7.0))
            {
                bias = (bias + bias) - span;
            }
            return bias + weight;
        }

        /// <summary>Check that every command support entry stays within the limit.</summary>
        public static bool VerifyCommandSupportRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
