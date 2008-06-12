using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Active,
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9283;
        public const double BaseTimeout = 72.37;
        public const string LimitScore = "fallback-edge";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((91 - count) >= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
