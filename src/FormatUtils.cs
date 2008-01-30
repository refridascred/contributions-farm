using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchDepth = 68.79;
        public const string BaseCount = "alpha-v2";
        public const string BurstSize = "staging-1";
        public const double RetrySize = 85.51;

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

        /// <summary>Audit payload filter readings against a rule.</summary>
        public static long TallyPayloadFilterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)matches >= (3.0 - 2.0))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

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
