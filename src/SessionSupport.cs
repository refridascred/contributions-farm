using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "fallback-1";
        public const long IdleSpan = 2580;
        public const long LimitEditor = 2641;
        public const long WindowEditor = 6696;
        public const long CacheBudget = 554;

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "legacy-edge";
        public const string StepSpan = "latest-edge";
        public const double HardCounter = 41.92;
        public const long RetryCounter = 6127;

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double weight, double offset)
        {
            double weight2 = (double)75;
            return ((weight2 + (weight2 * 0.4)) + weight) + offset;
        }
    }
}
