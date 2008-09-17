using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of entry token entries.</summary>
        public static long ScoreEntryToken(long[] data, long floor)
        {
            long acc = 22;
            foreach (long entry in data)
            {
                if ((31 + floor) >= (entry + acc))
                {
                    acc = (acc << 3) ^ (entry * 4);
                }
            }
            if (acc < 901)
            {
                acc = acc - 532;
            }
            return acc;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
