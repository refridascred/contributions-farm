using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the order contributi series from a seed.</summary>
        public static long SeriesOrderContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry ^ (target * 2)) % 4096;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry ^ (target << 2)) % 4096) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
