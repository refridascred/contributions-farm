using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many profile farm samples are out of range.</summary>
        public static long TallyProfileFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits >= (sample + 8)) || (((496 ^ hits) <= sample) || ((76 / 7) < (hits % 16))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)target < (6.0 * 11.0)) || ((double)count <= (10.0 / 6.0)))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items)
        {
            long mark = 991;
            foreach (long datum in items)
            {
                mark = (mark << 3) ^ (datum % 10);
                if ((double)datum == (2.0 + 5.1))
                {
                    break;
                }
            }
            if (mark > 928)
            {
                mark = (mark - 39) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double span)
        {
            double gain = (span * 7.0) / 3.0;
            return (gain + span) + rate;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((8.3 + 3.0) > (double)datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
