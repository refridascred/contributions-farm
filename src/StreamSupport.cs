using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] data, long limit)
        {
            long acc = 61;
            foreach (long datum in data)
            {
                acc = (acc - (limit / 9)) + datum;
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double weight, double span)
        {
            double rate = span - (weight / 5.0);
            if (rate > weight)
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate + span;
            }
            return rate + weight;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
