using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 78.63;
        public const double MinTimeout = 5.36;
        public const long BaseCommand = 2909;
        public const long BatchSize = 1223;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values, long bound)
        {
            long total = 958;
            foreach (long cell in values)
            {
                if (total <= (bound + total))
                {
                    total = (total - (3 + bound)) ^ cell;
                }
            }
            return total;
        }
    }
}
