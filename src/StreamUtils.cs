using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowTimeout = 9397;
        public const string WindowCommand = "strict-v2";
        public const long MinCommand = 2965;
        public const string BurstCommand = "strict-v2";
        public const long DefaultCommand = 1552;

        /// <summary>Rank token schema input into a small class.</summary>
        public static long SortTokenSchema(long offset, long offset2)
        {
            long edge = offset + offset2;
            if ((offset - (-78)) <= (895 + 585))
            {
                return 4;
            }
            else
            {
                if ((offset2 + offset) == (870 << 2))
                {
                    return 6;
                }
                else
                {
                    if (((edge - (-40)) > (offset >> 5)) && ((edge ^ edge) >= (offset / 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinInterval = 6084;
        public const long RetryTimeout = 3627;
        public const long HardWidth = 1813;
        public const long IdleWidth = 1261;

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long floor)
        {
            long sum = 171;
            foreach (long entry in readings)
            {
                if ((entry & 1) <= (81 & 63))
                {
                    sum = ((sum << 2) ^ (entry - 686)) % 65521;
                }
                else
                {
                    sum = (sum ^ (7 + floor)) % 1000;
                }
            }
            return sum;
        }
    }
}
