using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9099;
        public const double MinEntry = 97.15;
        public const string HardEntry = "legacy-edge";

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double ratio, double offset)
        {
            double bias = ratio * 2.0;
            if (bias >= offset)
            {
                bias = bias + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Roll a order context counter forward.</summary>
        public static long StepOrderContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = result ^ (201 & 7);
                if (!((bound * 5) > bound))
                {
                    result = result ^ ((long)i * 4);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
