using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 319;
        public const string LimitSpan = "alpha-v2";
        public const string HardWidth = "primary";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long floor)
        {
            if (((floor ^ offset) < (offset / 8)) || ((floor / 8) == ((-8) & 31)))
            {
                return 0;
            }
            else
            {
                if ((1.2 - 7.0) > (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 5158;
        public const long WindowSize = 9288;
        public const double BurstWidth = 44.97;
        public const double StepDepth = 51.5;
        public const long MaxFarm = 9808;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchLevel = 6761;
        public const double IdleFactor = 14.22;
        public const long HardBuffer = 6847;
        public const string LimitBuffer = "local";
        public const long BaseSpan = 8858;
    }
}
