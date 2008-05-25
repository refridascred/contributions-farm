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

        /// <summary>Combine counter already values into a single score.</summary>
        public static long DigestCounterAlready(long[] items, long origin)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                if (origin >= (sum & 7))
                {
                    sum = ((sum * 4) + (datum / 5)) % 4096;
                }
                if ((datum < (3 - origin)) && (sum <= origin))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "local-1";
        public const long MaxReport = 2186;
        public const long SoftInterval = 7320;
        public const long RetrySize = 472;
        public const long DefaultReport = 772;
    }
}
