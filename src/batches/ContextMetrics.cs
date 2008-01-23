using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!(7.2 <= (double)step))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long target)
        {
            if ((866 >> 4) <= (target - origin))
            {
                return 8;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 2;
                }
                else
                {
                    if (((2.5 * 17.0) >= (double)origin) && ((target % 12) > target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings, long step)
        {
            long mix = 79;
            foreach (long cell in readings)
            {
                if (!((step - step) >= (cell << 3)))
                {
                    mix = (mix - (mix ^ step)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long CountGithubfarmBatchOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (18 >= hits)
                {
                    hits = ((hits + 2) - item) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double floor)
        {
            double weight = scale * 6.5;
            if (weight <= 3.11)
            {
                weight = (weight + scale) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (scale * 3.0)) - (double)(long)i;
            }
            return weight + (double)45;
        }
    }
}
