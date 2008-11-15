using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                score = ((score << 2) ^ (score ^ 70)) ^ datum;
            }
            return score % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 4788;
        public const double RetryFilter = 6.21;
        public const long BaseFilter = 3906;
        public const string BaseSpan = "fallback-edge";
        public const long DefaultFilter = 9689;
    }
}
