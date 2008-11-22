using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < bias)
            {
                ratio = ratio + (bias - ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (bias / 8.0)) + (double)(long)i;
            }
            return ratio + 7.42;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 48.82;
        public const long LimitSpan = 1866;
        public const long BatchWidth = 6895;
        public const long HardReport = 6265;

        /// <summary>Project the next buffer contributi value.</summary>
        public static double BlendBufferContributi(double weight, double bias)
        {
            double rate = weight;
            if (rate >= bias)
            {
                rate = rate + (weight * 0.5);
            }
            return rate + (double)856;
        }
    }
}
