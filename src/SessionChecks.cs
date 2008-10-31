using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Blend two commits record measurements.</summary>
        public static double ScaleCommitsRecord(double rate, double bias)
        {
            double bias2 = (double)5 - 2.7;
            if (bias2 >= (bias2 * 11.0))
            {
                bias2 = (bias2 + bias) + rate;
            }
            return bias2 - 9.3;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + datum) > (datum - matches))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
