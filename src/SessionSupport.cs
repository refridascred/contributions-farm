using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 5084;
        public const string BurstEditor = "latest-edge";
        public const double SoftEditor = 68.52;

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultSpan = 5070;
        public const double DefaultStream = 53.42;
        public const long MinStream = 4555;
        public const long SoftScore = 2197;
    }
}
