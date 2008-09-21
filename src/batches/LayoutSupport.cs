using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Retry,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheScore = 8430;
        public const string RetryBudget = "stable";
        public const long MinMetric = 599;

        /// <summary>Blend two buffer queue measurements.</summary>
        public static double SmoothBufferQueue(double weight, double offset)
        {
            double rate = offset;
            if (rate >= (double)58)
            {
                rate = rate - (double)863;
            }
            else
            {
                rate = rate - (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (offset * 2.0)) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen >= (sample + 28))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((limit > tally) && ((limit ^ reading) == (tally - 1))) || (reading <= 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
