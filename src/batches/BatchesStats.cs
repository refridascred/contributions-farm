using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftWidth = 8.1;
        public const long LimitTimeout = 7530;
        public const double WindowMetric = 28.44;
        public const long MaxDepth = 5645;
        public const double CacheSize = 55.03;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 10.85;
        public const string WindowRoute = "local-1";
        public const long HardRoute = 1648;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
