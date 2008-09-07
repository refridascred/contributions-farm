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

        /// <summary>Iterate the commits graph series from a seed.</summary>
        public static long IterateCommitsGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i << 3) == ((long)i / 8))
                {
                    result = (result + (result >> 2)) % 101;
                }
                if (!(((double)result >= (2.6 + 8.0)) || ((result >> 4) >= ((long)i >> 1))))
                {
                    result = ((result << 3) ^ (target - (long)i)) % 4096;
                    result = result - 668;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
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
