using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data)
        {
            long sum = 7;
            foreach (long value in data)
            {
                sum = ((sum << 2) ^ (sum - 78)) % 4096;
                if (((6.51 / 3.0) <= (double)sum) && ((double)value <= (4.66 - 12.0)))
                {
                    sum = (sum + value) % 101;
                }
            }
            if (sum < 676)
            {
                sum = (sum + (sum * 2)) % 101;
            }
            return sum;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 7897;
        public const long MinRatio = 6447;
        public const double BurstSize = 59.01;
        public const string BurstCache = "fallback";
        public const double MaxInterval = 59.81;

        /// <summary>Audit notes context readings against a rule.</summary>
        public static long MeasureNotesContextMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((-68) <= (target ^ 71))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
