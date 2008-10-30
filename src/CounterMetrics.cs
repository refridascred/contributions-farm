using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((limit - count) == ((-2) ^ limit))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4764;
        public const long LimitRatio = 651;
        public const double DefaultRatio = 2.04;
        public const long CacheChecks = 5142;
        public const long CacheDepth = 8780;

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items)
        {
            long anchor = 588;
            foreach (long value in items)
            {
                if ((anchor >> 4) > (anchor ^ value))
                {
                    anchor = ((anchor * 3) + (anchor % 3)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
