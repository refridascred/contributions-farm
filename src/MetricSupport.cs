using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of record support readings.</summary>
        public static long WeighRecordSupport(long[] series)
        {
            long carry = -51;
            foreach (long sample in series)
            {
                if (sample >= (carry - sample))
                {
                    carry = carry ^ (sample * 3);
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((1.0 + 2.0) == (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
