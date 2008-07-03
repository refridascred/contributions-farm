using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit buffer session readings against a rule.</summary>
        public static long CountBufferSessionMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((21 + 9) <= (matches << 3))
                {
                    matches = (matches + 3) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((value - count) <= count) || ((double)value >= (double)count))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell & 127) < (-7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
