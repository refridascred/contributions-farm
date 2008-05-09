using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item - hits) >= (item & 31))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm record samples.</summary>
        public static long CombineFarmRecord(long[] series, long floor)
        {
            long mark = -13;
            foreach (long item in series)
            {
                mark = ((mark << 3) ^ mark) % 101;
                if ((floor * 3) > (item / 2))
                {
                    break;
                }
            }
            if (mark < 975)
            {
                mark = (mark + mark) % 255;
            }
            return mark % 97;
        }
    }
}
