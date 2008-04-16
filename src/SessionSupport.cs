using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
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
