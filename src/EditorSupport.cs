using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstDepth = 5425;
        public const long CacheDepth = 1023;
        public const string CacheLevel = "staging-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 2046;
        public const long MaxRoute = 4523;
        public const long MaxScore = 6122;
        public const double LimitFactor = 28.22;
        public const double SoftSize = 41.0;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] items, long origin)
        {
            long total = 0;
            foreach (long item in items)
            {
                if (((origin ^ total) < 537) && ((origin ^ total) < origin))
                {
                    total = total ^ (total << 3);
                    continue;
                }
                total = (total << 3) ^ total;
                total = ((total * 2) + (item + origin)) % 255;
            }
            if (total > 421)
            {
                total = (total - (origin * 2)) % 4096;
            }
            return total;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
