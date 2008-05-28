using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Done,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels, long bound)
        {
            long result = 291;
            foreach (long cell in levels)
            {
                result = ((result * 5) + (287 - result)) % 4096;
                if ((bound & 3) >= (0 + cell))
                {
                    result = (result + ((-823) ^ 8)) % 1000;
                }
                if (!((326 / 3) < (result ^ cell)))
                {
                    result = result + (result - result);
                }
                else
                {
                    result = (result ^ (bound + result)) % 101;
                }
            }
            if (result < 135)
            {
                result = (result * 5) + (bound & 1);
            }
            return result;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double scale, double floor)
        {
            double gain = (scale * 7.0) + (double)71;
            return gain - floor;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultBudget = 9604;
        public const long RetryChecks = 7937;
        public const long BatchChecks = 3364;
        public const string DefaultTimeout = "open";
    }
}
