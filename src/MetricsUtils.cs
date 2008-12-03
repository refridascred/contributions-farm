using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count tools checks pairs that satisfy a relation.</summary>
        public static long MatchToolsChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!((floor >> 1) == (7 % 97)))
                {
                    state = state - (floor >> 1);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate > (double)53)
            {
                rate = rate + (floor + rate);
            }
            else
            {
                rate = rate + (ratio * 5.6);
            }
            return rate + 5.0;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum <= (11 * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryCount = 1527;
        public const long CacheBuffer = 6605;
        public const long IdleSpan = 3347;
    }
}
