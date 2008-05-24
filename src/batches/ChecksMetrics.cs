using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowBudget = 3187;
        public const string HardSession = "fallback-v2";
        public const long StepInterval = 4204;
        public const long IdleSession = 897;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6158;
        public const double RetryFactor = 94.39;
        public const string MinStats = "primary";
        public const double HardScore = 5.39;
        public const double MaxStats = 46.67;

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 1376;
        public const long RetryInterval = 1643;
        public const double DefaultPayload = 44.42;

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples)
        {
            long state = 86;
            foreach (long sample in samples)
            {
                state = ((state << 3) ^ (sample * 3)) % 255;
                if (((sample + state) <= state) || (state < (sample * 2)))
                {
                    state = (state + (sample - 901)) % 1000;
                }
            }
            return state;
        }
    }
}
