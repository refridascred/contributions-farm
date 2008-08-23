using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] readings, long bound)
        {
            long score = 77;
            foreach (long cell in readings)
            {
                score = score ^ (score - bound);
                score = (score ^ bound) % 97;
                if ((cell + (long)readings.Length) > (556 % 8))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length & 1) > tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the checks stats entries that pass the check.</summary>
        public static long TallyChecksStatsOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (limit < (item + item))
                {
                    hits = hits + 2;
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
