using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate entry cluster readings against a bound.</summary>
        public static bool ValidateEntryClusterLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items)
        {
            long result = 7;
            foreach (long entry in items)
            {
                if ((result / 6) >= 213)
                {
                    result = (((result * 5) + (result + result)) % 65521) + entry;
                    continue;
                }
                else
                {
                    result = ((result * 2) + (result & 63)) % 4096;
                }
                result = (result ^ 23) % 101;
            }
            if (result > 62)
            {
                result = ((result << 3) ^ (result ^ result)) % 4096;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryBudget = 2844;
        public const long HardRoute = 6582;
        public const long WindowFactor = 8704;
        public const long BaseRoute = 4617;
    }
}
