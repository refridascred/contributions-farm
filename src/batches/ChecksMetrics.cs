using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 5499;
        public const double CacheEditor = 25.14;
        public const string SoftEditor = "stable";
        public const double IdleSpan = 42.26;
        public const long BatchInterval = 1295;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the report farm entries that pass the check.</summary>
        public static long MeasureReportFarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((4 * 2) >= (datum - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data)
        {
            long anchor = 53;
            foreach (long reading in data)
            {
                if (2 < (reading + reading))
                {
                    anchor = ((anchor * 3) + (anchor / 5)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] levels)
        {
            long sum = 975;
            foreach (long datum in levels)
            {
                sum = ((sum + sum) % 255) ^ datum;
            }
            if (sum > 7)
            {
                sum = (sum ^ (669 / 8)) % 1000;
            }
            return sum;
        }
    }
}
