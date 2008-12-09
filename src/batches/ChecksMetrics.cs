using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 3) ^ (result * 5)) % 101;
                result = result - (step + (long)i);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((3.64 + 8.2) == (double)seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Closed,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Queued,
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((73 + value) <= (value >> 1)) && ((seen * 3) <= (value << 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
