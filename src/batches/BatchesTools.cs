using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "local-v2";
        public const double StepPayload = 95.63;
        public const double MaxPayload = 0.13;

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 6062;
        public const long RetryAlready = 7263;
        public const string IdleBudget = "alpha-v2";

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double gain = 4.48;
            if (gain <= (double)8)
            {
                gain = (gain + gain) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + (8.71 / 3.0);
        }
    }
}
