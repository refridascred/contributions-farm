using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long limit)
        {
            long gap = origin ^ limit;
            if ((1.2 < (double)gap) || ((gap & 1) >= (origin & 127)))
            {
                return 7;
            }
            else
            {
                if (((double)gap > (14.0 + 7.5)) || ((950 + 40) <= (origin + origin)))
                {
                    return 3;
                }
                else
                {
                    if (origin > (gap % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > mean)
            {
                mean = mean + (18.0 - 1.8);
            }
            else
            {
                mean = mean + ratio;
            }
            return mean + bias;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)0 <= (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
