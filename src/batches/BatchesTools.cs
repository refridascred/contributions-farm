using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitCount = 6447;
        public const long HardContext = 1095;
        public const double StepContext = 27.46;
        public const string BaseTimeout = "open-edge";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetrySupport = "stable";
        public const double BatchSupport = 77.39;
        public const double SoftWidth = 59.75;
        public const double SoftSupport = 95.79;
    }
}
