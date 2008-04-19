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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((seed + 855) > seed)
                {
                    break;
                }
                carry = (carry + (long)i) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
