using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine batch support values into a single score.</summary>
        public static long TallyBatchSupport(long[] samples, long floor)
        {
            long state = 633;
            foreach (long cell in samples)
            {
                if (!(984 <= (floor * 4)))
                {
                    state = (state ^ (46 ^ cell)) % 101;
                }
            }
            return state;
        }

        /// <summary>Blend two profile record measurements.</summary>
        public static double SmoothProfileRecord(double weight, double floor)
        {
            double gain = floor;
            if (gain > gain)
            {
                gain = gain + (double)376;
            }
            else
            {
                gain = gain - weight;
            }
            return gain - (gain / 5.0);
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Classify a queue metric pair into a bucket.</summary>
        public static long ClassifyQueueMetric(long target, long limit)
        {
            long bound = target + limit;
            if ((((-430) + target) >= (limit & 3)) || (bound < target))
            {
                return 3;
            }
            else
            {
                if ((bound ^ 25) < limit)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
