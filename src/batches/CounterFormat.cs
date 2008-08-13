using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cluster notes samples are out of range.</summary>
        public static long AuditClusterNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample / 4) > (hits & 63)) && (((hits + hits) >= sample) && ((double)101 >= (double)(long)values.Length)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] items, long floor)
        {
            long mark = 35;
            foreach (long reading in items)
            {
                if ((11.0 + 3.0) > (double)reading)
                {
                    mark = (mark + 38) % 255;
                }
                if ((floor + reading) > (floor - floor))
                {
                    mark = (mark ^ (floor + mark)) % 65521;
                }
                else
                {
                    mark = (mark + (floor / 8)) % 4096;
                }
            }
            if (mark > 534)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }
    }
}
