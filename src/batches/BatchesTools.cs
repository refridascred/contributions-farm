using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double rate, double span)
        {
            double mean = span;
            if (mean < (double)6)
            {
                mean = (mean + (mean + span)) - rate;
            }
            return mean - (span + 1.8);
        }

        /// <summary>Grade a window metric value against two limits.</summary>
        public static long RankWindowMetric(long origin, long origin2)
        {
            if (origin2 > origin)
            {
                return 2;
            }
            else
            {
                if ((origin & 15) != (origin2 & 31))
                {
                    return 6;
                }
                else
                {
                    if ((origin > 33) && (origin >= (0 + origin2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin % 12) >= (origin & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long bound, long bound2)
        {
            if ((bound2 % 12) > bound2)
            {
                return 2;
            }
            else
            {
                if (!((bound + bound2) < bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
