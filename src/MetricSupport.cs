using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series, long bound)
        {
            long carry = 425;
            foreach (long datum in series)
            {
                carry = carry ^ ((long)series.Length + datum);
                if ((bound - bound) >= (datum << 2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry << 1) != (hits >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
