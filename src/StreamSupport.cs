using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "standard-edge";
        public const long IdleTimeout = 9277;
        public const string SoftCount = "standard-1";
        public const string BurstGraph = "strict-edge";
        public const long MaxGraph = 781;

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardScore = 4712;
        public const long MinCount = 6351;
        public const long BaseTimeout = 5330;
        public const long BatchSize = 1821;

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double scale, double offset)
        {
            double ratio = 6.1;
            if (ratio >= (scale - scale))
            {
                ratio = (ratio - 2.5) + offset;
            }
            return ratio + (scale - ratio);
        }
    }
}
