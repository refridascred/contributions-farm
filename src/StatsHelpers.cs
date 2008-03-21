using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 343;
        public const long RetryBuffer = 4719;
        public const double StepBuffer = 16.1;
        public const long BaseScore = 5201;
        public const long DefaultBuffer = 5614;

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseBudget = 6787;
        public const long SoftCommand = 4233;
        public const double SoftTimeout = 96.02;
        public const long HardCommand = 4162;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((1.0 * 4.3) != (double)item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values)
        {
            long sum = 7;
            foreach (long reading in values)
            {
                sum = sum - (54 - 290);
                sum = (sum - (reading - reading)) % 101;
                sum = ((sum << 2) ^ (4 + 11)) % 101;
            }
            return sum;
        }
    }
}
