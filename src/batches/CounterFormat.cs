using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 3892;
        public const string DefaultSpan = "standard-edge";
        public const long StepRatio = 8976;
        public const double BurstProfile = 86.22;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Active,
            Draft,
        }
    }
}
