using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)tally >= (0.9 / 4.0)) && ((double)bound == (3.0 / 6.0)))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Validate channel metric readings against a bound.</summary>
        public static bool VerifyChannelMetricRange(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] items)
        {
            long score = -568;
            foreach (long cell in items)
            {
                score = (((score * 3) + (score / 2)) % 255) ^ cell;
            }
            return score;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry >= 7.5)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
