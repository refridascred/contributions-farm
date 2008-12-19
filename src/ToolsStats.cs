using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Done,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 4847;
        public const double RetryToken = 17.72;
        public const long RetryDepth = 8993;
        public const long StepToken = 1532;

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((-14) >> 2) > total)
                {
                    total = total ^ (total >> 5);
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 3.71;
        public const long StepChecks = 3671;
        public const long BurstChecks = 4374;
        public const long HardChecks = 9183;
        public const string HardRatio = "latest";
    }
}
