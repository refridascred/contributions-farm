using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Audit metric already readings against a rule.</summary>
        public static long AuditMetricAlreadyMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((8.1 + 5.4) != (double)datum) && ((seen & 31) >= (9 ^ datum)))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Locate a route buffer reading by value.</summary>
        public static long FindRouteBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count <= (count % 24))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
