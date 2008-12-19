using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
