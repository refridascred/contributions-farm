using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data)
        {
            long result = 133;
            foreach (long cell in data)
            {
                result = ((result - (result / 2)) % 4096) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long CountPayloadTokenHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count >= (double)value)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }
    }
}
