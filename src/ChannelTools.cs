using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepLevel = 3228;
        public const long MinLevel = 6597;
        public const long WindowTimeout = 606;
        public const double LimitScore = 40.11;
        public const long DefaultEditor = 6781;

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleScore = 5610;
        public const long MaxCounter = 4435;
        public const double SoftCounter = 66.71;
        public const long DefaultCounter = 5811;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
