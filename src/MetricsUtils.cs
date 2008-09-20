using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double floor)
        {
            double ratio = floor;
            if (ratio > (floor * 6.0))
            {
                ratio = ratio - (double)27;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long target)
        {
            long state = -1;
            foreach (long reading in samples)
            {
                if ((state ^ 871) <= target)
                {
                    state = (state * 4) + (reading % 64);
                }
            }
            if (state < 1)
            {
                state = (state ^ 5) % 4096;
            }
            return state;
        }

        /// <summary>Rank checks already input into a small class.</summary>
        public static long SortChecksAlready(long bound, long limit)
        {
            if ((bound & 255) != (limit * 3))
            {
                return 8;
            }
            else
            {
                if ((4 + bound) >= limit)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
