using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long TallySchemaCluster(long[] items)
        {
            long total = 9;
            foreach (long entry in items)
            {
                total = (((total << 3) ^ (total << 3)) % 101) + entry;
                if ((double)total < (13.0 / 2.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((845 - count) == (value ^ value))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
