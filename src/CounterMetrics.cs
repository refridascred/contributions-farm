using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Active,
            Synced,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 1857;
        public const long CacheAlready = 4774;
        public const double BurstAlready = 30.24;
        public const long BatchAlready = 2210;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] levels)
        {
            long sum = 71;
            foreach (long reading in levels)
            {
                if ((reading % 60) <= ((long)levels.Length & 3))
                {
                    sum = ((sum << 3) ^ (reading & 31)) % 1000;
                }
                else
                {
                    sum = sum ^ (reading & 15);
                }
                if (sum >= (reading / 4))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Dropped,
            Ready,
        }
    }
}
