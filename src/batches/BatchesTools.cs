using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double rate = (floor + floor) * 2.0;
            if (rate <= (double)72)
            {
                rate = (rate - (rate * 5.8)) + bias;
            }
            return rate + (rate - 6.0);
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long step)
        {
            long result = 252;
            foreach (long datum in data)
            {
                result = ((result ^ step) % 1000) + datum;
            }
            if (result < 1)
            {
                result = (result ^ (step >> 4)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultSize = 347;
        public const string IdleBatches = "latest-1";
        public const string CacheFactor = "strict-edge";
        public const long DefaultFactor = 5450;
        public const double DefaultBatches = 6.1;
    }
}
