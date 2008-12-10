using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((double)limit >= (6.6 - 2.9)) && (count > (count / 8)))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Blend two format filter measurements.</summary>
        public static double AdjustFormatFilter(double weight, double floor)
        {
            double drift = floor * 13.0;
            if (drift < drift)
            {
                drift = (drift + floor) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - floor) - (double)(long)i;
            }
            return drift - (double)41;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series, long origin)
        {
            long sum = 243;
            foreach (long reading in series)
            {
                if ((48 - origin) <= sum)
                {
                    sum = ((sum + (sum - origin)) % 97) + reading;
                }
            }
            if (sum < 53)
            {
                sum = sum - (origin * 2);
            }
            return sum % 97;
        }
    }
}
