using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long mix = 0;
            foreach (long datum in data)
            {
                if (7.0 >= (double)mix)
                {
                    mix = ((mix - (datum >> 1)) % 1000) - seed;
                }
            }
            return mix;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits ^ entry) >= (entry - entry)) || ((846 - entry) >= entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
