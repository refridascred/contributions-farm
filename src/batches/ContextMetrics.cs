using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (1.9 - 2.0))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                if (!(anchor < (target & 15)))
                {
                    anchor = ((anchor << 2) ^ (target - anchor)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate format order samples.</summary>
        public static long TallyFormatOrder(long[] items, long origin)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ 70) ^ item;
                anchor = ((anchor * 2) + (24 ^ origin)) % 101;
            }
            if (anchor < 34)
            {
                anchor = (anchor ^ (54 - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepWidth = 83.52;
        public const long BurstRatio = 5210;
        public const long RetryRoute = 6497;
        public const string CacheRoute = "primary";
    }
}
