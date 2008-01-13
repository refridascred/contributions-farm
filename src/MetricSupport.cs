using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally + sample) != (42 ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long origin, long bound)
        {
            long span = origin - bound;
            if ((bound << 2) == (origin - origin))
            {
                return 5;
            }
            else
            {
                if ((span * 3) > span)
                {
                    return 6;
                }
                else
                {
                    if ((bound ^ (-919)) <= (span + span))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.13 - 2.0) >= (4.4 / 8.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token queue measurements.</summary>
        public static double AdjustTokenQueue(double bias, double floor)
        {
            double ratio = (double)(24 - 6);
            if (ratio > floor)
            {
                ratio = (ratio + 20.0) + bias;
            }
            return ratio - ratio;
        }
    }
}
