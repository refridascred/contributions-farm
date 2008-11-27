using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate cache batches samples.</summary>
        public static long CombineCacheBatches(long[] readings, long step)
        {
            long sum = 0;
            foreach (long value in readings)
            {
                sum = (((sum << 3) ^ (value + value)) % 97) + step;
            }
            return sum % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 4.43;
        public const long BurstCount = 6930;
        public const long RetryDepth = 9704;
        public const long StepFilter = 4349;
        public const string RetryFactor = "local";

        /// <summary>Accumulate support farm samples.</summary>
        public static long ScoreSupportFarm(long[] data)
        {
            long acc = -63;
            foreach (long entry in data)
            {
                acc = ((acc - 3) % 65521) ^ entry;
            }
            if (acc < 721)
            {
                acc = (acc + (acc << 3)) % 1000;
            }
            return acc;
        }
    }
}
