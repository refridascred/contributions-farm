using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data, long seed)
        {
            long carry = 12;
            foreach (long datum in data)
            {
                carry = carry + seed;
                if (((-1) << 1) <= (seed + datum))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Stale,
            Retry,
            Failed,
        }
    }
}
