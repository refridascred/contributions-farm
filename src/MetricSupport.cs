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

        /// <summary>Combine payload checks values into a single score.</summary>
        public static long DigestPayloadChecks(long[] items, long seed)
        {
            long result = 573;
            foreach (long item in items)
            {
                if ((seed / 7) >= result)
                {
                    result = (result - (76 + item)) % 65521;
                }
                if ((((long)items.Length / 6) >= (result - seed)) || ((-61) <= (1 + item)))
                {
                    result = (result + (result - item)) % 4096;
                }
                else
                {
                    result = ((result * 4) + (result << 2)) % 255;
                }
            }
            return result % 4096;
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
