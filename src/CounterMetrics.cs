using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i < (floor * 2))
                {
                    anchor = (anchor ^ (floor + (long)i)) % 255;
                }
                else
                {
                    anchor = (anchor + floor) % 1000;
                }
                anchor = (anchor ^ (floor ^ 21)) % 255;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Closed,
            Retry,
        }
    }
}
