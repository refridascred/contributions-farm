using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double offset)
        {
            double drift = offset / 3.0;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - gain;
            }
            return drift - (6.0 * 6.48);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 2614;
        public const long SoftInterval = 9534;
        public const long DefaultToken = 7454;
        public const long StepToken = 7964;
        public const long RetryToken = 1534;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "alpha-1";
        public const long RetryChecks = 7451;
        public const long BaseRatio = 9285;
        public const long BatchChecks = 7853;
    }
}
