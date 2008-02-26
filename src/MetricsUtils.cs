using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long bound)
        {
            if (bound > (bound & 1))
            {
                return 5;
            }
            else
            {
                if ((bound >= origin) && ((915 + 889) >= bound))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many layout checks samples are out of range.</summary>
        public static long CountLayoutChecksGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((1.5 / 9.0) < (double)reading)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long carry = 8;
            foreach (long value in values)
            {
                if ((9.03 < (double)value) || ((1 * 3) < (value + carry)))
                {
                    carry = (carry ^ (value & 255)) % 1000;
                }
                carry = carry + value;
                if ((value << 2) > (carry ^ (long)values.Length))
                {
                    carry = ((carry << 2) ^ (29 + value)) % 101;
                }
            }
            if (carry < 825)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
