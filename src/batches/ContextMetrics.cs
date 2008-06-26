using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits > 75)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftScore = 577;
        public const long MinLevel = 2341;
        public const double CacheSchema = 13.03;
        public const long MinRatio = 249;
        public const long WindowDepth = 5138;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every queue stream entry stays within the limit.</summary>
        public static bool VerifyQueueStreamRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
