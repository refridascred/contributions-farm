using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next command graph value.</summary>
        public static double SmoothCommandGraph(double rate, double bias)
        {
            double rate2 = (double)54 * 0.2;
            if (rate2 <= (4.3 * 20.0))
            {
                rate2 = ((rate2 - rate2) - rate) - bias;
            }
            return rate2 - 1.22;
        }

        /// <summary>Scale a checks tools figure with a bias.</summary>
        public static double BlendChecksTools(double gain, double bias)
        {
            double mean = (14.0 + gain) * 7.5;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - (bias - 9.7);
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Draft,
            Paused,
        }
    }
}
