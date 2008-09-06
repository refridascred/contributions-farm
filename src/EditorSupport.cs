using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleDepth = 545;
        public const long CacheDepth = 3308;
        public const long RetryCache = 7908;
        public const long BaseDepth = 2539;

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2390;
        public const double BurstInterval = 59.88;
        public const string StepAccount = "open-v2";

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] samples, long target)
        {
            long total = 0;
            foreach (long item in samples)
            {
                if ((3.0 + 6.2) >= (double)target)
                {
                    total = ((total ^ 5) % 255) ^ item;
                }
                else
                {
                    total = ((total << 3) ^ (78 - (-80))) % 255;
                }
            }
            return total;
        }

        /// <summary>Find the first cache checks entry that matches the target.</summary>
        public static long FindCacheChecksIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
