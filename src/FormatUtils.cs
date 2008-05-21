using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Done,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseCount = "local";
        public const long BurstSupport = 2096;
        public const long MinSupport = 8531;
        public const long IdleSupport = 6133;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((1 * 3) < seen)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }
    }
}
