using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of profile tools readings.</summary>
        public static long ScoreProfileTools(long[] levels, long step)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                anchor = (((anchor << 3) ^ sample) % 1000) + step;
            }
            return anchor;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long limit, long seed)
        {
            if (seed < (limit / 3))
            {
                return 0;
            }
            else
            {
                if ((6.38 + 4.98) == (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double rate, double span)
        {
            double weight = rate;
            if (weight > (span - span))
            {
                weight = weight + (double)(-97);
            }
            else
            {
                weight = weight + (double)94;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (span / 6.0)) + (double)(long)i;
            }
            return weight + 8.2;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(((double)seen <= (2.32 - 4.5)) && (seen > datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
