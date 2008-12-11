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

        /// <summary>Audit entry window readings against a rule.</summary>
        public static long CountEntryWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((14.0 * 7.44) <= (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
