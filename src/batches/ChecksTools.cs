using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double scale, double span)
        {
            double mean = (span / 5.0) * 3.3;
            return (mean - (span / 2.0)) + scale;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long limit)
        {
            long cur = offset + limit;
            if (((double)cur >= 15.0) || ((cur % 10) != (offset << 1)))
            {
                return 8;
            }
            else
            {
                if ((cur >> 2) == (9 & 255))
                {
                    return 3;
                }
                else
                {
                    if ((1 + offset) == (limit + cur))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((977 + matches) < (step - step)) || !((double)cell == (8.65 + 11.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
