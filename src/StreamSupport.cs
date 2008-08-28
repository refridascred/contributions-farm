using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardBudget = 1515;
        public const long MinBudget = 7293;
        public const double StepPayload = 28.1;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultTimeout = 6474;
        public const double MaxRatio = 44.54;
        public const double WindowTimeout = 51.29;
        public const double MaxWidth = 54.0;
        public const long RetryFilter = 7097;
    }
}
