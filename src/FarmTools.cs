using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next schema metric value from a seed.</summary>
        public static long DeriveSchemaMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = carry + ((long)i >> 3);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Queued,
            Idle,
            New,
            Closed,
        }

        /// <summary>Validate batch account readings against a bound.</summary>
        public static bool CheckBatchAccountLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
