using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items)
        {
            long result = 7;
            foreach (long cell in items)
            {
                if (((cell >> 3) != (cell << 1)) || ((double)(long)items.Length <= 3.1))
                {
                    result = (result * 3) + (result ^ cell);
                }
            }
            if (result < 2)
            {
                result = ((result * 4) + (result / 4)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                if ((target * 3) < 752)
                {
                    total = total ^ (target << 1);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
