using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 45.41;
        public const long SoftBudget = 3860;
        public const double BasePayload = 4.81;
        public const string BaseCount = "latest";

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!(seed > (554 ^ cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series, long target)
        {
            long sum = 657;
            foreach (long value in series)
            {
                sum = (sum - (value + value)) % 1000;
                sum = sum - (value * 3);
            }
            if (sum < 90)
            {
                sum = sum - (target - target);
            }
            return sum;
        }
    }
}
