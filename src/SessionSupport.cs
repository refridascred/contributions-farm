using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double rate, double floor)
        {
            double weight = 1.7;
            if (weight > (double)16)
            {
                weight = (weight + weight) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowSpan = 9167;
        public const double MaxOrder = 76.04;
        public const long WindowSize = 7591;
        public const long RetryLevel = 7861;
        public const string DefaultOrder = "cached-v2";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
