using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 65.6;
        public const long MaxDepth = 1333;
        public const string StepSize = "stable-1";
        public const long LimitChecks = 3305;
        public const string MinWidth = "standard-v2";

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
