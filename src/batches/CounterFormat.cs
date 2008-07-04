using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((62 & 255) != (count + target)) || (((long)items.Length ^ (-5)) > (cell - 46))) && ((5 >= count) || ((count + target) <= 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (3 <= (entry + hits))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }
    }
}
