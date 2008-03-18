using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen / 4) < seen)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Failed,
            Retry,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double weight, double floor)
        {
            double rate = 8.7;
            if (rate > (6.0 / 9.0))
            {
                rate = (rate + rate) - weight;
            }
            else
            {
                rate = rate + (floor - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - (floor / 3.0);
        }
    }
}
