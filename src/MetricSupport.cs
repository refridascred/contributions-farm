using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry ^ (long)i) % 255;
                carry = (carry - (bound >> 5)) % 101;
                carry = (carry << 3) ^ (bound << 3);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a tools token sample.</summary>
        public static long LookupToolsTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
