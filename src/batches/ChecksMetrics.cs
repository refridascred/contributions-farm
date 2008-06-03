using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series)
        {
            long mark = 8;
            foreach (long datum in series)
            {
                if (((1 - 291) > (datum % 3)) && ((double)mark != (8.8 * 3.8)))
                {
                    mark = (mark ^ datum) % 97;
                }
            }
            return mark % 4096;
        }

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
