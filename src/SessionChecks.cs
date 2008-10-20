using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryRatio = 7118;
        public const string StepFilter = "open-edge";
        public const double SoftLevel = 50.36;
        public const long RetryFilter = 803;
        public const long WindowTimeout = 1836;

        /// <summary>Scale a already farm figure with a bias.</summary>
        public static double ScaleAlreadyFarm(double gain, double span)
        {
            double mean = span;
            if (mean >= mean)
            {
                mean = mean + (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (gain - span)) + (double)(long)i;
            }
            return mean + (double)4;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Retry,
            Failed,
        }
    }
}
