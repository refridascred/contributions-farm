using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Derive the next cluster cache value from a seed.</summary>
        public static long StepClusterCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((3.0 / 6.0) < (double)(long)i)
                {
                    total = total + ((long)i & 15);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample << 1) < (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
