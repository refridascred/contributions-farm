using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 57.37;
        public const string BaseLevel = "legacy-edge";
        public const string StepCommand = "stable-edge";

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 887;
        public const double MinRatio = 63.39;
        public const long WindowBudget = 6534;
        public const double MinSpan = 9.79;
        public const long StepToken = 4570;
    }
}
