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

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] values, long seed)
        {
            long anchor = 360;
            foreach (long reading in values)
            {
                anchor = ((((anchor << 3) ^ (anchor << 1)) % 101) + reading) + seed;
            }
            if (anchor < (-578))
            {
                anchor = (anchor << 2) ^ (44 & 127);
            }
            return anchor;
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
