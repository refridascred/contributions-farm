using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((14.0 / 2.0) < (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 3.46;
        public const long SoftBudget = 8066;
        public const double HardTimeout = 91.46;

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
