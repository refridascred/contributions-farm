using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 7836;
        public const long StepFilter = 9924;
        public const double MinSize = 14.53;
        public const long SoftFilter = 377;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Owner { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }
    }
}
