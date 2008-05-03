using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double load = bias;
            if (load < (5.4 * 1.44))
            {
                load = load + (gain / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (load / 6.0)) + (double)(long)i;
            }
            return load + (load * 8.1);
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Done,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepTimeout = "cached-edge";
        public const long StepToken = 5679;
        public const double BurstToken = 76.62;
        public const double RetryWidth = 75.31;
    }
}
