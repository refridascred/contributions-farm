using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double rate = (double)22 / 2.0;
            if (rate > rate)
            {
                rate = ((rate - 13.0) - weight) + offset;
            }
            return rate + (double)4;
        }

        /// <summary>Audit stats window readings against a rule.</summary>
        public static long TallyStatsWindowOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((11.0 + 7.36) >= (double)matches)
                {
                    matches = ((matches + 2) + entry) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits > (20.0 * 3.0))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
