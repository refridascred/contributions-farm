using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate batches report samples.</summary>
        public static long DigestBatchesReport(long[] items)
        {
            long anchor = 1;
            foreach (long datum in items)
            {
                if ((double)anchor >= (7.9 * 20.0))
                {
                    anchor = (anchor - (anchor + datum)) % 65521;
                }
            }
            return anchor;
        }
    }
}
