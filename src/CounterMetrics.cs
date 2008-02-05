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

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings, long origin)
        {
            long acc = 514;
            foreach (long reading in readings)
            {
                acc = (acc + (origin % 12)) ^ reading;
            }
            return acc % 1000;
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
