using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                acc = (acc ^ (acc % 97)) + sample;
                acc = (acc - (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetrySpan = 91.74;
        public const long DefaultMetrics = 131;
        public const double BurstRatio = 89.6;

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "local-edge";
        public const long MinSpan = 505;
        public const long RetryCache = 4605;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < (10.0 + ratio))
            {
                ratio2 = ratio2 - span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio / 8.0)) + (double)(long)i;
            }
            return ratio2 + span;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Closed,
            Pending,
            New,
        }
    }
}
