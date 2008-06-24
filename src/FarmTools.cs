using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 7150;
        public const long StepChannel = 5295;
        public const double StepScore = 15.66;
        public const long SoftSize = 9453;
        public const long LimitChannel = 1717;

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 93.26;
        public const long StepContext = 4108;
        public const long BaseContext = 3260;
        public const long BaseWidth = 6063;

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 8191;
        public const long MaxSize = 3593;
        public const long StepSpan = 9936;
    }
}
