using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleSpan = "alpha-edge";
        public const long HardSpan = 8861;
        public const double CacheBudget = 1.74;
        public const long BatchFactor = 9550;

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state ^ (floor * 4)) % 97;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
