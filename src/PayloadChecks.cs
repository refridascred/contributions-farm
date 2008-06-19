using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double rate, double bias)
        {
            double load = (bias / 8.0) - rate;
            if (load > 3.82)
            {
                load = load - rate;
            }
            return load - (load * 3.7);
        }

        /// <summary>Count the cache layout entries that pass the check.</summary>
        public static long AuditCacheLayoutMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((limit << 1) < limit) && !((tally * 2) <= cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Failed,
            New,
            Queued,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
