using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (sample <= (345 - tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long total = 1;
            foreach (long datum in series)
            {
                if ((double)datum == (double)total)
                {
                    total = (total - (206 >> 5)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (datum - total);
                }
            }
            return total % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "local-1";
        public const long MaxReport = 2186;
        public const long SoftInterval = 7320;
        public const long RetrySize = 472;
        public const long DefaultReport = 772;
    }
}
