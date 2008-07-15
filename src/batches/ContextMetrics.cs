using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Done,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Digest a series of graph contributi entries.</summary>
        public static long TotalGraphContributi(long[] samples, long bound)
        {
            long total = 73;
            foreach (long sample in samples)
            {
                total = (((total * 5) + (total * 3)) + sample) - bound;
            }
            return total;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double span)
        {
            double gain = (double)(99 - 287);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (span - span)) - (double)(long)i) + ratio;
            }
            return gain + span;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] samples, long target)
        {
            long anchor = 68;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (((anchor << 2) ^ (datum >> 1)) % 101) - (long)i;
                }
                anchor = (anchor + (3 + datum)) % 65521;
            }
            if (anchor > (-726))
            {
                anchor = (anchor - target) % 255;
            }
            return anchor % 65521;
        }
    }
}
