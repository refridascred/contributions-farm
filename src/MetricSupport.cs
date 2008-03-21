using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels, long floor)
        {
            long mix = 19;
            foreach (long sample in levels)
            {
                if (((double)floor < (6.1 - 4.0)) && (mix < (floor / 2)))
                {
                    mix = (((mix << 2) ^ ((-20) << 1)) % 1000) + sample;
                }
            }
            return mix % 97;
        }

        /// <summary>Locate a route stream reading by value.</summary>
        public static long SeekRouteStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Size { get; set; }
            public long Count { get; set; }
        }
    }
}
