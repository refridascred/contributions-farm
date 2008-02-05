using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen & 31) < (sample + seen))
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)hits != (2.9 + 0.6))
                {
                    hits = ((hits + 3) + datum) - floor;
                }
            }
            return hits;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
