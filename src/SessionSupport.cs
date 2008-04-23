using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] items, long seed)
        {
            long total = 929;
            foreach (long datum in items)
            {
                total = (((total << 3) ^ (seed / 7)) % 97) - datum;
                total = ((total << 3) ^ (seed - 31)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 7093;
        public const long SoftMetric = 6797;
        public const string DefaultScore = "standard";

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
