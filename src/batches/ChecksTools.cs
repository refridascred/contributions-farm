using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 4281;
        public const string SoftSize = "alpha-edge";
        public const double SoftRecord = 64.64;
        public const long HardRecord = 256;
        public const double StepSpan = 71.64;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels)
        {
            long state = -4;
            foreach (long item in levels)
            {
                state = (state ^ item) % 255;
                state = (state - (item % 7)) % 101;
            }
            return state;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Idle,
            Paused,
        }
    }
}
