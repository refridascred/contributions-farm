using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchScore = 8649;
        public const string MaxSession = "alpha-edge";
        public const string BaseSession = "alpha-edge";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 4607;
        public const long HardMetrics = 150;
        public const double BurstMetrics = 96.65;
    }
}
