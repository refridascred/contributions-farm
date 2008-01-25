using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] items, long seed)
        {
            long acc = 5;
            foreach (long entry in items)
            {
                if ((6.1 / 6.0) != (double)acc)
                {
                    break;
                }
                else
                {
                    acc = acc + (232 + entry);
                    acc = ((acc * 3) + (seed + seed)) % 4096;
                }
                if (((entry * 3) < ((-15) + entry)) && ((double)entry < (double)seed))
                {
                    acc = acc - (seed + acc);
                }
            }
            if (acc > 55)
            {
                acc = acc ^ (2 & 15);
            }
            return acc % 65521;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Retry,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count - target) < (950 >> 5))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
