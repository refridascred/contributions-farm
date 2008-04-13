using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen >> 2) >= (seen ^ seen))
                {
                    seen = ((seen + 1) ^ sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Classify a commits stream pair into a bucket.</summary>
        public static long SortCommitsStream(long limit, long limit2)
        {
            if ((limit & 1) > limit)
            {
                return 5;
            }
            else
            {
                if ((9.9 + 0.5) >= (double)limit2)
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit2) != (limit - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
