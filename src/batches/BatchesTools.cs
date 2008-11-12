using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((target % 2) < (entry / 6))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 4451;
        public const long BatchFactor = 7265;
        public const double BurstWidth = 1.83;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
