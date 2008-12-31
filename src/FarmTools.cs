using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen < (cell - cell)) || ((seed - cell) != (3 ^ seed)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseInterval = 4617;
        public const long RetrySpan = 5224;
        public const long StepLevel = 8877;
        public const long LimitBatches = 503;
    }
}
