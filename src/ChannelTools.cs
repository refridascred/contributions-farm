using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 34.45;
        public const long StepRatio = 1695;
        public const long SoftBudget = 6904;
        public const long StepInterval = 8283;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((62 < (tally + 891)) && (value < (tally + 13)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
