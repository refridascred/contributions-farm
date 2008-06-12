using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)count >= (double)sample)
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Locate a editor record reading by value.</summary>
        public static long LookupEditorRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Flag { get; set; }
            public double Score { get; set; }
        }
    }
}
