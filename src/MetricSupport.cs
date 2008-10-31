using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen & 31) != (97 - bound))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
