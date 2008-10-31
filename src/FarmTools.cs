using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardRatio = 4555;
        public const string StepFilter = "alpha-1";
        public const long StepBudget = 7024;
        public const long LimitFilter = 1873;
        public const long WindowFilter = 2850;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Done,
            New,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "legacy-1";
        public const long CacheAlready = 37;
        public const long StepAlready = 3512;
        public const long DefaultRatio = 2380;
    }
}
