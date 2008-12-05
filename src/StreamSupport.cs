using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] data, long limit)
        {
            long acc = 61;
            foreach (long datum in data)
            {
                acc = (acc - (limit / 9)) + datum;
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long limit, long origin)
        {
            if ((-21) >= (origin % 64))
            {
                return 1;
            }
            else
            {
                if ((limit + origin) == (limit << 2))
                {
                    return 8;
                }
                else
                {
                    if (origin <= (limit ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
