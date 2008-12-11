using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a queue graph counter forward.</summary>
        public static long IterateQueueGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 2) ^ seed) % 1000;
                if (!((total >> 3) <= ((long)i ^ (long)i)))
                {
                    total = (total << 3) ^ ((long)i >> 3);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryFactor = 399;
        public const string DefaultTimeout = "primary-edge";
        public const long WindowSession = 5964;
        public const string BurstSession = "standard";

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9915;
        public const long RetryFilter = 1419;
        public const long WindowFilter = 956;
    }
}
