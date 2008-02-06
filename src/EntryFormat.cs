using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySpan = 4488;
        public const long IdleReport = 2553;
        public const long LimitWidth = 4637;

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long floor)
        {
            long prev = offset ^ floor;
            if ((double)prev < (18.0 * 7.31))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) >= (floor + floor))
                {
                    return 8;
                }
                else
                {
                    if (prev < (6 + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Ready,
            Retry,
            Paused,
            Draft,
        }
    }
}
