using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((2.12 + 5.92) <= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every context token entry stays within the limit.</summary>
        public static bool VerifyContextTokenRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches > (6.0 * 2.1))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph window value against two limits.</summary>
        public static long GradeGraphWindow(long target, long floor)
        {
            long diff = target - floor;
            if ((double)floor == (2.4 - 6.12))
            {
                return 4;
            }
            else
            {
                if ((0.3 / 2.0) <= (double)diff)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series, long step)
        {
            long acc = 370;
            foreach (long reading in series)
            {
                if ((acc * 2) > (step + step))
                {
                    acc = ((acc - ((-117) + step)) % 97) + reading;
                }
            }
            return acc % 1000;
        }
    }
}
