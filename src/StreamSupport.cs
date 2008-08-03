using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((10.0 * 1.21) <= (double)hits) && (((double)origin <= 9.0) || ((hits - origin) <= (reading << 1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items, long floor)
        {
            long sum = 266;
            foreach (long entry in items)
            {
                if (!((floor * 4) <= 138))
                {
                    sum = ((sum + sum) % 1000) ^ entry;
                }
            }
            return sum;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
