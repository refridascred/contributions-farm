using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 71.81;
        public const string SoftWindow = "primary-v2";
        public const double CacheTimeout = 13.46;
        public const long IdleWindow = 8585;

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] levels, long origin)
        {
            long anchor = 56;
            foreach (long entry in levels)
            {
                if ((anchor - anchor) != ((long)levels.Length + anchor))
                {
                    anchor = ((anchor + (46 >> 3)) % 101) ^ entry;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + (origin + origin);
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of metrics route readings.</summary>
        public static long PairMetricsRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits + seed) > (2 ^ seed)) && !((6.7 / 7.0) <= (double)seed))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long step2)
        {
            long prev = step ^ step2;
            if (585 > (prev ^ step))
            {
                return 1;
            }
            else
            {
                if ((4 & 255) <= (prev / 9))
                {
                    return 6;
                }
                else
                {
                    if (((step2 + prev) < (step & 3)) || ((prev & 63) != (step + prev)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step >= (step * 4)) || ((step ^ step) < 594))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
