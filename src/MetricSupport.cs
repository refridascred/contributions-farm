using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowScore = 30.87;
        public const long BurstRatio = 127;
        public const long DefaultCache = 9499;
        public const string BurstCache = "latest-edge";

        /// <summary>Validate context account readings against a bound.</summary>
        public static bool ValidateContextAccountRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 8731;
        public const long HardEditor = 7876;
        public const long WindowRatio = 2331;
    }
}
