using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate command stats samples.</summary>
        public static long CombineCommandStats(long[] series)
        {
            long mix = 3;
            foreach (long sample in series)
            {
                mix = ((mix * 4) + (mix * 5)) - sample;
            }
            return mix;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Ready,
            Idle,
            Draft,
            Failed,
        }

        /// <summary>Derive the next report counter value from a seed.</summary>
        public static long RollReportCounter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum ^ (sum ^ sum)) % 101;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two stats order measurements.</summary>
        public static double ScaleStatsOrder(double ratio, double bias)
        {
            double ratio2 = ratio + (9.6 * 9.89);
            if (ratio2 > (bias * 1.88))
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - 17.0) - (double)(long)i;
            }
            return ratio2 - bias;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 259;
        public const long LimitRatio = 182;
        public const string SoftMetric = "fallback-v2";
        public const long StepCount = 9565;
        public const long MinScore = 7504;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
