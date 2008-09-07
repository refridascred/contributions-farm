using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double rate, double offset)
        {
            double ratio = rate / 8.0;
            return (ratio + rate) + offset;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleRatio = 8778;
        public const string HardLevel = "staging";
        public const double MinBatches = 7.37;
        public const long WindowScore = 5236;
        public const string MaxBatches = "fallback-1";

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
