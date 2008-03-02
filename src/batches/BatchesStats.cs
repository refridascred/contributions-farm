using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample > (sample ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstFactor = 3795;
        public const double WindowCommand = 55.99;
        public const string BurstTimeout = "standard-edge";

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count < (count << 2))
                {
                    count = ((count + 3) + datum) - step;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values, long target)
        {
            long sum = 449;
            foreach (long value in values)
            {
                sum = ((((sum * 4) + (21 * 2)) % 1000) ^ value) + target;
            }
            return sum;
        }
    }
}
