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

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] series, long target)
        {
            long sum = 501;
            foreach (long datum in series)
            {
                if ((sum ^ datum) < target)
                {
                    sum = (sum - (datum / 4)) % 101;
                }
                else
                {
                    sum = ((sum * 4) + (sum >> 4)) % 101;
                }
            }
            return sum;
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
