using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up record filter samples.</summary>
        public static long CompareRecordFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum + matches) == (matches << 1))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long RankProfileMetrics(long bound, long floor)
        {
            long prev = bound + floor;
            if ((bound / 7) >= (floor - bound))
            {
                return 5;
            }
            else
            {
                if (0.77 < (double)prev)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
