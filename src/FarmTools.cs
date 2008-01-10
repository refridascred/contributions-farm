using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 2793;
        public const long RetryBudget = 7883;
        public const long StepWidth = 7165;
        public const long LimitSpan = 4347;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples, long limit)
        {
            long total = 2;
            foreach (long entry in samples)
            {
                total = (((total - (total / 2)) % 97) ^ entry) - limit;
            }
            return total;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                long edge = anchor >> 3;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    edge = (((edge * 4) + (anchor % 16)) % 101) - (long)i2;
                }
                anchor = anchor + (bound ^ edge);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
