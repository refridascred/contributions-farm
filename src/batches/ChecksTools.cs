using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = total ^ seed;
                    total = (total - ((long)i2 + total)) % 4096;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)value >= (8.3 / 3.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxInterval = 6181;
        public const long CacheFactor = 9916;
        public const long BaseCount = 2756;
        public const string BurstBudget = "fallback-edge";
        public const string MinScore = "strict-1";

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Retry,
            Locked,
        }
    }
}
