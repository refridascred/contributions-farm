using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long TallyToolsGithubfarmMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - 784) < (7 + entry))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((344 + cell) <= (cell - step)) || ((seen * 2) <= (cell & 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a schema graph pair into a bucket.</summary>
        public static long RankSchemaGraph(long floor, long limit)
        {
            long gap = floor + limit;
            if ((gap + gap) <= (60 & 15))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) >= gap)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= 9.2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((gap + limit) >= (gap ^ (-74)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double ratio = (floor + floor) + (floor / 7.0);
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) - weight;
            }
            return ratio + (9.1 * 6.7);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (3 < limit)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
