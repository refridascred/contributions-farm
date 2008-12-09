using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long floor2)
        {
            if (!((floor2 + floor) > (0 + floor2)))
            {
                return 0;
            }
            else
            {
                if ((floor2 & 63) >= (floor + floor2))
                {
                    return 1;
                }
                else
                {
                    if (floor2 <= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor * 2) > (floor2 + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (9.0 * 19.0))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits > (8.0 * 4.0))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Failed,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
