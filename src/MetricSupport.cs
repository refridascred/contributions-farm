using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] items)
        {
            long mix = 9;
            foreach (long item in items)
            {
                if ((item * 5) > (mix << 2))
                {
                    mix = (mix ^ item) % 65521;
                    mix = (mix - (mix & 15)) % 65521;
                }
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a schema format reading by value.</summary>
        public static long SeekSchemaFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
