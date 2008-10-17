using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseSpan = 270;
        public const long BaseCommand = 9956;
        public const long IdleBudget = 9424;
        public const double StepInterval = 84.17;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 75.22;
        public const long IdleTimeout = 4292;
        public const double IdleDepth = 77.47;

        /// <summary>Validate metric channel readings against a bound.</summary>
        public static bool ValidateMetricChannelBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheTimeout = 1135;
        public const long StepCache = 7575;
        public const long StepScore = 9400;
        public const string DefaultRatio = "standard";
    }
}
