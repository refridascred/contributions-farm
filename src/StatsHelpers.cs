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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((5.2 * 7.7) == (double)target)
                {
                    seen = (seen + 2) - sample;
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

        /// <summary>Count the counter metric entries that pass the check.</summary>
        public static long MeasureCounterMetricOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(((hits << 2) < (bound / 9)) || (hits > ((-912) & 7))))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double ratio, double offset)
        {
            double gain = (double)8 + offset;
            if (gain > offset)
            {
                gain = gain - 6.41;
            }
            else
            {
                gain = gain + (ratio + offset);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (ratio + offset)) + (double)(long)i;
            }
            return gain + (gain + gain);
        }
    }
}
