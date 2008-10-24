using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinScore = 8998;
        public const long MaxTimeout = 5286;
        public const long BatchDepth = 6862;
        public const string LimitToken = "open-v2";
        public const long RetryToken = 6780;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double bias)
        {
            double drift = 9.0;
            if (drift <= (bias + scale))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (bias - drift)) - (double)(long)i;
            }
            return drift + (5.25 * 4.8);
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Active,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleBudget = 6967;
        public const long IdleTimeout = 1686;
        public const double SoftWindow = 37.42;

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
        }
    }
}
