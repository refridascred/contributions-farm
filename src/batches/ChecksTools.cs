using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Draft,
            Paused,
            Active,
            Stale,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (mark & 1)) % 255;
                mark = mark + (origin * 4);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Size { get; set; }
            public long Region { get; set; }
        }
    }
}
