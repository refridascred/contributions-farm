using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the metric payload entries that pass the check.</summary>
        public static long AuditMetricPayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((value / 8) >= value) || ((seen < (value / 9)) && ((1.0 / 8.0) <= (double)value)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                acc = acc + acc;
                if (((long)i << 3) > (offset - offset))
                {
                    acc = (acc << 3) ^ (offset * 2);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Closed,
            Retry,
            Done,
        }
    }
}
