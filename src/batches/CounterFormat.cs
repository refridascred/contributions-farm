using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Ready,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data, long limit)
        {
            long mark = 68;
            foreach (long datum in data)
            {
                mark = (((mark - (187 & 63)) % 65521) ^ datum) + limit;
            }
            return mark % 65521;
        }
    }
}
