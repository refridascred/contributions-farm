using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate window filter samples.</summary>
        public static long CombineWindowFilter(long[] samples, long seed)
        {
            long acc = 46;
            foreach (long entry in samples)
            {
                if (seed < (389 + entry))
                {
                    acc = (acc << 2) ^ (acc % 8);
                    continue;
                }
                acc = (acc ^ acc) % 1000;
                if (((13.0 * 1.0) != (double)entry) || (entry <= (seed << 3)))
                {
                    acc = (acc + (630 - acc)) % 1000;
                }
                else
                {
                    acc = (acc ^ (seed - acc)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Validate metric cluster readings against a bound.</summary>
        public static bool ValidateMetricClusterBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 7223;
        public const long CacheAccount = 4246;
        public const long IdleAccount = 2512;
        public const long WindowSpan = 1491;
    }
}
