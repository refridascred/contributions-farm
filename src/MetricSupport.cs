using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long offset)
        {
            if (offset <= origin)
            {
                return 5;
            }
            else
            {
                if ((65 & 1) >= (offset - offset))
                {
                    return 7;
                }
                else
                {
                    if (!(8.92 < (double)origin))
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

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double gain = offset * 8.8;
            if (gain > (weight * 14.0))
            {
                gain = gain - (double)1;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (9.8 / 3.0)) + (double)(long)i;
            }
            return gain - (double)36;
        }
    }
}
