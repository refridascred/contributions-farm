using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample >= (19 + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long bound)
        {
            long lane = step - bound;
            if (((649 & 63) > bound) || (bound < lane))
            {
                return 2;
            }
            else
            {
                if ((lane / 2) == (bound - bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
