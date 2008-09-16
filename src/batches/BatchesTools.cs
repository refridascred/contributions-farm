using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                result = (result ^ (73 + 813)) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit queue notes readings against a rule.</summary>
        public static long TallyQueueNotesOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!!(offset > (7 << 1)))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
