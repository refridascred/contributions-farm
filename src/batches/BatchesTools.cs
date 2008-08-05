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

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (target < (hits + target))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

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
