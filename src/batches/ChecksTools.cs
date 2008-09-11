using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((double)seen <= (double)datum) || (datum >= (datum - 9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Draft,
            Queued,
            Paused,
            Pending,
            Closed,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Count { get; set; }
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
