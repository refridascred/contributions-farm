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

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double rate, double floor)
        {
            double mean = rate;
            if (mean >= 5.0)
            {
                mean = mean + (mean / 8.0);
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + 3.04) + (double)(long)i;
            }
            return mean - 5.05;
        }
    }
}
