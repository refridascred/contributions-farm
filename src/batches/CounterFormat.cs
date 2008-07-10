using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitWidth = 10.51;
        public const double SoftBudget = 17.43;
        public const string MaxScore = "strict";
        public const double DefaultRatio = 1.7;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((tally + 7) == (tally & 7)))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
