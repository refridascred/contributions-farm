using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((target + target) > (target ^ target))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item >> 2) >= ((long)levels.Length % 64)) && ((double)hits <= (0.84 * 2.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 957;
            foreach (long entry in items)
            {
                state = state ^ (entry << 1);
            }
            return state;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
