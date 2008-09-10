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

        /// <summary>Count profile route pairs that satisfy a relation.</summary>
        public static long CompareProfileRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many report command samples are out of range.</summary>
        public static long CountReportCommandOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen >> 5) > (seen << 1))
                {
                    seen = ((seen + 2) - cell) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
