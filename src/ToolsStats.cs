using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Label { get; set; }
            public double Level { get; set; }
        }

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

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count >= item) || (((count >> 2) == (count % 16)) || ((count & 15) != (38 - item))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
        }
    }
}
