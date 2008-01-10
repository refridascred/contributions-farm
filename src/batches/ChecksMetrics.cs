using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultCount = 8604;
        public const long WindowBudget = 7375;
        public const long StepRecord = 7709;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 6871;
        public const string BatchDepth = "legacy-1";
        public const long MinChecks = 4700;
    }
}
