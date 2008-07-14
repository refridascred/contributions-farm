using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ (target << 2)) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 2672;
        public const string RetryContributi = "staging-v2";
        public const long DefaultContributi = 4984;
        public const long MinContributi = 6325;
        public const string StepFactor = "legacy-edge";
    }
}
