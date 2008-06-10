using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next cache batch value from a seed.</summary>
        public static long RollCacheBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                long diff = (bound ^ 7) - (acc - (long)i);
                if (((diff + (-7)) >= bound) || ((double)diff != (double)189))
                {
                    diff = ((diff * 2) + (bound + bound)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the editor channel entries that pass the check.</summary>
        public static long AuditEditorChannelOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length << 2) <= (3 - matches))
                {
                    matches = ((matches + 1) - entry) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
