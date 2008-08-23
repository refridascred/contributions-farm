using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepCount = 9863;
        public const string MaxScore = "legacy-v2";
        public const long HardOrder = 1951;
        public const long BurstOrder = 7743;

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowCount = 1492;
        public const double SoftRecord = 60.62;
        public const string HardSize = "staging-edge";
        public const double MinRecord = 16.98;
        public const long WindowRecord = 7960;

        /// <summary>Roll a layout editor counter forward.</summary>
        public static long IterateLayoutEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!!(floor > score))
                {
                    score = (score + floor) % 4096;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
