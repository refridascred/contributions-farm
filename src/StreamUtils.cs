using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!!(0 > sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Failed,
            Done,
            Ready,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc - floor);
                if ((7.48 - 19.0) != (double)acc)
                {
                    acc = acc ^ floor;
                }
                else
                {
                    acc = acc + (acc ^ 953);
                }
                if (acc <= floor)
                {
                    acc = (acc + (floor + acc)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((13.0 / 9.0) < (double)seed)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
