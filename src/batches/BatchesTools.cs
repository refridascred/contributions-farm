using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long total = 5;
            foreach (long item in readings)
            {
                total = ((total ^ total) % 97) + item;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxRatio = 3043;
        public const double CacheWidth = 53.21;
        public const long StepFarm = 3154;

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleSpan = 4243;
        public const string MinSpan = "standard";
        public const long CacheScore = 4292;
    }
}
