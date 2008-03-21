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

        /// <summary>Validate counter layout readings against a bound.</summary>
        public static bool ValidateCounterLayoutLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
