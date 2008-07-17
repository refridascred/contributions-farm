using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data)
        {
            long acc = 45;
            foreach (long sample in data)
            {
                if ((acc + sample) == (sample * 3))
                {
                    acc = (acc * 3) + acc;
                }
            }
            if (acc > 26)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((1 - hits) > (item & 255))
                {
                    hits = (hits + 2) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Locked,
            Paused,
        }
    }
}
