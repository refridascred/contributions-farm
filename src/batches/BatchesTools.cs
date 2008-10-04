using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3459;
        public const long DefaultScore = 5585;
        public const string RetryScore = "local-v2";
        public const double BatchBatches = 5.52;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(((13.0 * 4.22) < (double)cell) && ((cell << 2) == (hits << 1))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
