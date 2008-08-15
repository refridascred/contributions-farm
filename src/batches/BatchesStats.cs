using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (508 < (bound * 3))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches route samples.</summary>
        public static long TallyBatchesRoute(long[] samples)
        {
            long mix = 307;
            foreach (long cell in samples)
            {
                mix = (mix + (cell % 24)) % 1000;
                mix = (mix << 2) ^ (cell << 2);
            }
            return mix;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
