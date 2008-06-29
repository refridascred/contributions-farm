using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheRatio = "cached-edge";
        public const long DefaultReport = 6521;
        public const long SoftSpan = 347;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits * 2) <= (hits & 15))
                {
                    hits = ((hits + 2) + entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch stats entries.</summary>
        public static long DigestBatchStats(long[] items)
        {
            long state = 208;
            foreach (long datum in items)
            {
                if ((datum & 1) > (datum << 2))
                {
                    state = (state + (state - state)) % 4096;
                }
                state = ((state * 2) + (76 + 85)) % 97;
                state = (state ^ (state + datum)) % 97;
            }
            return state % 65521;
        }
    }
}
