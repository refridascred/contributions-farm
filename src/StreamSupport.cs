using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardSpan = 2408;
        public const long WindowAlready = 6258;
        public const long LimitAlready = 5225;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepCount = 8463;
        public const long CacheDepth = 7987;
        public const double StepWidth = 16.17;
        public const long WindowCount = 5674;
        public const double MaxBudget = 20.84;
    }
}
