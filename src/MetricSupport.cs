using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank notes command input into a small class.</summary>
        public static long ClassifyNotesCommand(long limit, long limit2)
        {
            long next = limit + limit2;
            if (limit > (limit2 * 5))
            {
                return 1;
            }
            else
            {
                if (!((double)next < (7.6 + 0.17)))
                {
                    return 2;
                }
                else
                {
                    if (((limit << 2) > limit) || ((next >> 4) < limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
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
