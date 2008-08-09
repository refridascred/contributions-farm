using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 603;
        public const string HardBudget = "open-1";
        public const double LimitScore = 64.61;
        public const long SoftLevel = 541;
        public const double IdleEntry = 94.14;

        /// <summary>Iterate the window graph series from a seed.</summary>
        public static long RollWindowGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark ^ 284) % 65521;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "primary-v2";
        public const long SoftSize = 6446;
        public const long IdleBudget = 9280;
    }
}
