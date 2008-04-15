using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Region { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)seen != (9.3 + 13.0))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long MeasureBufferEditorMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) != (949 - seen))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long target)
        {
            long acc = 705;
            foreach (long entry in data)
            {
                if ((double)target >= 20.0)
                {
                    acc = (acc << 3) ^ (entry * 3);
                }
            }
            return acc;
        }
    }
}
