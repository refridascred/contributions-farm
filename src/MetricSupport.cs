using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples, long limit)
        {
            long carry = 10;
            foreach (long item in samples)
            {
                carry = carry + (item >> 2);
                for (int i = 0; i < 5; i++)
                {
                    carry = carry ^ (limit + (long)i);
                }
                if ((double)limit == (double)carry)
                {
                    carry = ((carry * 2) + (2 % 8)) % 101;
                }
            }
            if (carry < 853)
            {
                carry = carry + (limit % 60);
            }
            return carry;
        }

        /// <summary>Validate metrics stats readings against a bound.</summary>
        public static bool ValidateMetricsStatsRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
