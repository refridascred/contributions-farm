using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the schema notes entries that pass the check.</summary>
        public static long MeasureSchemaNotesMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((seed ^ sample) >= (count ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double rate = weight;
            if (rate < (rate - 0.29))
            {
                rate = (rate + (double)699) - offset;
            }
            else
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate - (rate / 7.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 1.41;
        public const long DefaultRatio = 9020;
        public const long RetryFarm = 419;
        public const double BaseFarm = 45.28;
        public const long RetryWidth = 8500;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Pending,
            Stale,
        }
    }
}
