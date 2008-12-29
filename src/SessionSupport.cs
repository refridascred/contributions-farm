using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 5161;
        public const long WindowSpan = 6779;
        public const long StepBuffer = 6087;
        public const string MinBuffer = "local-edge";
        public const long RetrySpan = 634;

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
