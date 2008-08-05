using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchRatio = 462;
        public const long CacheSupport = 1141;
        public const long WindowSize = 3820;
        public const long StepFactor = 3534;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 6107;
        public const long DefaultReport = 2899;
        public const long DefaultWidth = 3401;

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series, long step)
        {
            long state = 25;
            foreach (long entry in series)
            {
                if ((entry << 3) >= (entry ^ 16))
                {
                    state = ((state * 5) + (step * 2)) % 4096;
                }
            }
            return state % 97;
        }
    }
}
