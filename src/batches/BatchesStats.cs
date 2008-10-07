using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Draft,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Count the metric support entries that pass the check.</summary>
        public static long CountMetricSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry & 1) >= (count ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
