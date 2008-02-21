using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 4.55;
        public const long BatchEntry = 3280;
        public const long SoftEntry = 4462;
        public const long MaxScore = 303;

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowWidth = 5655;
        public const long BatchStats = 4994;
        public const long DefaultStats = 522;
        public const long HardStats = 9010;
        public const long StepStats = 3835;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((2.0 - 14.0) > (9.63 + 2.2))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
