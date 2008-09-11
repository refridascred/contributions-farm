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

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
