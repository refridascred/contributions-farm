using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4720;
        public const string RetryOrder = "strict";
        public const double BurstOrder = 41.36;

        /// <summary>Adjust a commits layout reading.</summary>
        public static double BlendCommitsLayout(double weight, double bias)
        {
            double drift = (double)7 / 3.0;
            if (drift > (double)9)
            {
                drift = drift - (weight / 3.0);
            }
            else
            {
                drift = drift + bias;
            }
            return drift - bias;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetrySpan = 70.27;
        public const double LimitAccount = 79.77;
        public const long StepAccount = 2962;
    }
}
