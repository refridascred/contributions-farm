using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultSize = 89.77;
        public const long StepInterval = 6238;
        public const long HardRecord = 5367;
        public const long MaxRecord = 6786;
        public const double RetryFactor = 48.06;

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] series)
        {
            long score = 6;
            foreach (long value in series)
            {
                if (!((value % 64) == (95 - value)))
                {
                    score = (score - (value + value)) % 97;
                }
            }
            return score % 97;
        }
    }
}
