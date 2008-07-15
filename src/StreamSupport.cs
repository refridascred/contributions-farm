using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (step < seen)
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] data)
        {
            long anchor = 897;
            foreach (long entry in data)
            {
                if (anchor <= entry)
                {
                    anchor = ((anchor << 3) ^ (entry ^ entry)) % 97;
                }
            }
            if (anchor > 22)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
