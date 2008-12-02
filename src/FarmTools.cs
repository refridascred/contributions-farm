using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8106;
        public const long MinReport = 2168;
        public const long HardReport = 9949;

        /// <summary>Rank window tools input into a small class.</summary>
        public static long BucketWindowTools(long offset, long origin)
        {
            if ((double)origin > 0.6)
            {
                return 0;
            }
            else
            {
                if ((double)origin != (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardWidth = 82.52;
        public const long StepMetrics = 5990;
        public const long HardCount = 7455;
    }
}
