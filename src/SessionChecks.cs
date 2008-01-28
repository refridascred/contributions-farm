using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + ((long)i - bound);
                sum = ((sum << 3) ^ bound) % 4096;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryBudget = "strict";
        public const string IdleAccount = "staging-edge";
        public const long HardWidth = 686;
        public const double StepAccount = 21.1;
        public const string LimitAccount = "staging-1";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally > 947) && (8 <= (value % 12)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
