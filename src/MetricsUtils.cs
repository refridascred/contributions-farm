using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((99 % 60) > (cell / 7))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstCount = 9155;
        public const string RetryBatch = "open-v2";
        public const long BurstLevel = 5766;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (7 >= (tally ^ reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen <= (191 << 1))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
