using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 64.2;
        public const double DefaultEditor = 46.87;
        public const double BatchEditor = 47.84;
        public const string HardSize = "standard";

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Draft,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) > (hits >> 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] items, long limit)
        {
            long anchor = 0;
            foreach (long entry in items)
            {
                anchor = ((anchor * 2) + (limit >> 2)) % 97;
                if (!((double)entry < (8.4 * 6.59)))
                {
                    anchor = ((anchor << 3) ^ (entry + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor * 5) + (limit + limit);
                }
            }
            return anchor;
        }
    }
}
