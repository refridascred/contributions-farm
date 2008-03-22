using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count > 44) || (value < ((long)samples.Length & 127))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long seed)
        {
            long sum = 787;
            foreach (long datum in levels)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (((sum << 2) ^ sum) % 101) ^ (long)i2;
                }
                if (((double)(long)levels.Length >= 7.9) || ((2.78 + 13.0) <= (double)datum))
                {
                    sum = (sum - (seed * 2)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ (seed - datum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Idle,
            Synced,
            Ready,
            Queued,
        }
    }
}
