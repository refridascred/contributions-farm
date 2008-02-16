using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((hits * 4) < hits))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen < (11.0 + 9.0))
                {
                    seen = ((seen + 2) - sample) - origin;
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score * 5) + (origin & 63)) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a checks metrics reading.</summary>
        public static double ProjectChecksMetrics(double rate, double bias)
        {
            double ratio = 1.6;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + bias;
            }
            return ratio - (rate - rate);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2063;
        public const long StepDepth = 2155;
        public const long BatchRoute = 1694;
        public const long WindowRoute = 9232;
        public const long CacheRoute = 2865;

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally > (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
