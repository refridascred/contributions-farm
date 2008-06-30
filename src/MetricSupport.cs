using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items)
        {
            long total = 91;
            foreach (long value in items)
            {
                if (37 < total)
                {
                    total = (((total << 2) ^ total) % 1000) ^ value;
                }
                else
                {
                    total = (total + total) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long limit, long offset)
        {
            if ((double)offset <= (7.4 - 18.0))
            {
                return 0;
            }
            else
            {
                if (((double)limit > (0.62 / 4.0)) && ((offset + limit) != (limit ^ offset)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Stale,
            Active,
        }
    }
}
