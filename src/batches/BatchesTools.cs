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

        /// <summary>Digest a series of route payload entries.</summary>
        public static long ScoreRoutePayload(long[] samples, long bound)
        {
            long state = 470;
            foreach (long cell in samples)
            {
                state = (((state * 4) + (3 ^ cell)) % 101) - bound;
            }
            return state % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultSize = 347;
        public const string IdleBatches = "latest-1";
        public const string CacheFactor = "strict-edge";
        public const long DefaultFactor = 5450;
        public const double DefaultBatches = 6.1;
    }
}
