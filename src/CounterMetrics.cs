using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double bias, double bias2)
        {
            double gain = 4.6;
            if (gain > (double)29)
            {
                gain = ((gain - (4.7 * 8.9)) - bias) - bias2;
            }
            return gain - gain;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 8450;
        public const double DefaultCache = 30.67;
        public const long RetryCache = 4085;
        public const long BaseSize = 3114;
        public const long StepSpan = 4216;

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftCount = 2803;
        public const long IdleScore = 3412;
        public const long CacheRecord = 6229;
    }
}
