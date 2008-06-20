using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long seed, long offset)
        {
            if ((seed % 7) <= offset)
            {
                return 1;
            }
            else
            {
                if ((seed >> 3) == (seed & 15))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed != (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long offset)
        {
            long step = bound ^ offset;
            if ((offset - offset) == (step + step))
            {
                return 1;
            }
            else
            {
                if ((double)step >= (2.86 + 0.1))
                {
                    return 2;
                }
                else
                {
                    if ((offset - step) != (bound + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two graph window measurements.</summary>
        public static double AdjustGraphWindow(double rate, double floor)
        {
            double ratio = (floor * 8.85) + (double)802;
            if (ratio <= (double)(-563))
            {
                ratio = (ratio + 3.1) + rate;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Count the stats report entries that pass the check.</summary>
        public static long TallyStatsReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((1.32 / 8.0) != (double)hits)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Closed,
            Failed,
            Pending,
            Paused,
        }
    }
}
