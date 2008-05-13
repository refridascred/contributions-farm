using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine queue session values into a single score.</summary>
        public static long FoldQueueSession(long[] series, long offset)
        {
            long anchor = -1;
            foreach (long datum in series)
            {
                anchor = (((anchor - (anchor * 5)) % 65521) ^ datum) + offset;
            }
            return anchor;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
