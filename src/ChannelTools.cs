using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double offset)
        {
            double gain = scale / 5.0;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 4701;
        public const long StepLevel = 854;
        public const long IdleSession = 7675;
        public const long StepSession = 5942;
        public const long SoftBudget = 8878;
    }
}
