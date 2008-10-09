using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstBudget = 5613;
        public const long HardLevel = 4989;
        public const long BatchStats = 1367;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 3624;
        public const double MinRoute = 27.03;
        public const string WindowRoute = "primary";
        public const long RetryRoute = 8307;
    }
}
