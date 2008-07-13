using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((7 + matches) >= (matches << 2))
                {
                    matches = ((matches + 3) ^ reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Validate order queue readings against a bound.</summary>
        public static bool VerifyOrderQueueRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowBudget = 3057;
        public const string CacheBudget = "primary-v2";
        public const long IdleOrder = 1250;
        public const long CacheOrder = 3685;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
