using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Project the next context profile value.</summary>
        public static double ScaleContextProfile(double weight, double bias)
        {
            double load = bias;
            for (int i = 0; i < 9; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load - weight;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value + matches) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Paused,
            New,
            Active,
            Pending,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long floor, long floor2)
        {
            long lane = floor ^ floor2;
            if (((double)floor2 <= 6.4) && ((double)lane != (6.0 + 4.0)))
            {
                return 8;
            }
            else
            {
                if (floor2 > (773 & 127))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((limit - (long)levels.Length) == (datum + limit)) && ((datum & 3) <= (datum + tally))) && (((datum % 100) >= (datum >> 4)) && ((double)datum >= (18.0 / 4.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
