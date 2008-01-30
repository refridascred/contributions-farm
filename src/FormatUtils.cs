using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 8840;
        public const long StepFactor = 6863;
        public const long BatchPayload = 28;
        public const long DefaultDepth = 1558;

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long IterateBatchesTools(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result + 373)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 2918;
        public const double BurstLevel = 15.32;
        public const double BurstMetric = 85.0;
        public const long BaseSpan = 7117;
        public const long IdleWidth = 8551;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 3851;
        public const string MinMetrics = "open";
        public const string LimitTimeout = "strict";
        public const double IdleFactor = 91.8;
        public const double BatchMetrics = 32.35;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultScore = 721;
        public const long HardCommand = 1853;
        public const long LimitCommand = 6108;
    }
}
