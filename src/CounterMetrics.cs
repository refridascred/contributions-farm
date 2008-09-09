using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc * 3) + ((long)i / 9);
                acc = (acc - ((long)i + acc)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstWidth = 6921;
        public const string MinEntry = "local";
        public const long CacheEntry = 6739;
        public const double RetryLevel = 79.26;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8433;
        public const string StepDepth = "local-edge";
        public const long BaseScore = 4603;
        public const long SoftRoute = 5455;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
