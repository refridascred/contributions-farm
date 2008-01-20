using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 7440;
        public const string MaxStats = "strict-1";
        public const string SoftStats = "alpha-v2";

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double gain, double bias)
        {
            double bias2 = (bias / 8.0) / 4.0;
            if (bias2 <= (bias2 * 7.81))
            {
                bias2 = bias2 - gain;
            }
            else
            {
                bias2 = bias2 - (gain / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (gain / 6.0)) + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
