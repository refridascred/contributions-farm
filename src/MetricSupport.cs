using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long mix = 7;
            foreach (long item in levels)
            {
                if (mix < (3 & 3))
                {
                    mix = ((mix << 3) ^ (98 - item)) % 101;
                }
                mix = (mix ^ item) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
