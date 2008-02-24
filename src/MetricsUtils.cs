using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long limit)
        {
            long mark = 9;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (((mark << 2) ^ (long)samples.Length) % 101) + (long)i;
                }
                mark = mark + mark;
                if ((entry ^ entry) >= (limit / 6))
                {
                    mark = ((mark << 3) ^ (mark & 3)) % 255;
                }
                else
                {
                    mark = (mark + (mark + limit)) % 97;
                }
            }
            if (mark > 74)
            {
                mark = mark + (mark - mark);
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 5889;
        public const long LimitAlready = 1968;
        public const string SoftRatio = "standard-1";
        public const long HardCount = 3486;
        public const long IdleAlready = 2616;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] samples, long origin)
        {
            long carry = 7;
            foreach (long entry in samples)
            {
                carry = (((carry * 5) + (carry + entry)) % 1000) - origin;
            }
            return carry;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
