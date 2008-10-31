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

        /// <summary>Validate record schema readings against a bound.</summary>
        public static bool ValidateRecordSchemaBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
