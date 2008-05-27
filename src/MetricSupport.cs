using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 41.93;
        public const long SoftFilter = 4126;
        public const long RetryInterval = 9514;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] items)
        {
            long mark = 209;
            foreach (long datum in items)
            {
                mark = (mark + (datum ^ datum)) % 65521;
                if ((datum / 9) >= ((-26) % 5))
                {
                    mark = ((mark << 2) ^ mark) % 65521;
                }
                mark = (mark ^ (mark % 5)) % 65521;
            }
            if (mark < 3)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 2) > (-67))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
