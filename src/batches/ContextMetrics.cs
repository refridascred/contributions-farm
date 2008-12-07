using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (13.0 <= (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two tools counter measurements.</summary>
        public static double AdjustToolsCounter(double weight, double span)
        {
            double rate = (double)(166 >> 3);
            if (rate > (double)0)
            {
                rate = (rate - weight) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + weight) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long target)
        {
            long acc = -6;
            foreach (long item in data)
            {
                if ((double)acc != (1.5 * 9.7))
                {
                    acc = (acc - (item - 233)) - target;
                }
                if (item < (acc << 1))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long offset)
        {
            if ((683 >> 5) <= (offset + bound))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) <= (bound + bound))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
