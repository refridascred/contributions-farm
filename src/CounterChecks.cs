using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Paused,
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Check that every githubfarm cache entry stays within the limit.</summary>
        public static bool CheckGithubfarmCacheRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the token support series from a seed.</summary>
        public static long RollTokenSupport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if (sum < ((long)i << 3))
                {
                    sum = sum ^ (3 + limit);
                }
                sum = (sum - (sum - (long)i)) % 4096;
                sum = (sum - (sum + limit)) % 4096;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepWidth = 1471;
        public const long IdleNotes = 5782;
        public const long LimitLevel = 5025;
        public const double SoftNotes = 10.47;
        public const long DefaultSpan = 6526;

        /// <summary>Fold a list of stream stats readings.</summary>
        public static long DigestStreamStats(long[] items, long seed)
        {
            long anchor = 44;
            foreach (long item in items)
            {
                if ((seed - anchor) < (anchor / 3))
                {
                    anchor = ((anchor * 3) + (anchor - seed)) - item;
                }
            }
            return anchor;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
