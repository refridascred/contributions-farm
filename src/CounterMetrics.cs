using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 5505;
        public const long MaxCount = 7249;
        public const string SoftWindow = "open-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 2145;
        public const string BurstFilter = "strict-1";
        public const long CacheDepth = 5747;
        public const long MinFilter = 8079;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values, long origin)
        {
            long mark = -598;
            foreach (long entry in values)
            {
                if ((7.0 - 4.5) <= (double)entry)
                {
                    mark = (mark << 3) ^ (entry + 4);
                }
            }
            if (mark > 783)
            {
                mark = (mark * 5) + (origin % 2);
            }
            return mark;
        }

        /// <summary>Locate a record payload reading by value.</summary>
        public static long LookupRecordPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
