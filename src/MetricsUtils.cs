using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Done,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + target) % 101;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((11.0 - 8.9) != (double)entry) && (1 >= (offset * 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches / 7) >= (matches * 3))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
