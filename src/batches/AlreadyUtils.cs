using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((70 + cell) > (47 - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((seen - (long)data.Length) == (8 - seen)) && ((1.0 > (double)seen) && ((double)seen <= (5.1 - 9.4))))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile account entries that pass the check.</summary>
        public static long TallyProfileAccountHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (seed <= (seed << 1))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Total { get; set; }
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value < (1.6 + 1.1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
