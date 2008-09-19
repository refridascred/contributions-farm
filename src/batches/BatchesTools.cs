using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= (scale + offset))
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + 9.0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultSize = 89.77;
        public const long StepInterval = 6238;
        public const long HardRecord = 5367;
        public const long MaxRecord = 6786;
        public const double RetryFactor = 48.06;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen - 408) <= 228)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
