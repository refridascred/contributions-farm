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

        /// <summary>Accumulate support format samples.</summary>
        public static long ScoreSupportFormat(long[] samples)
        {
            long total = 50;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total << 3) ^ ((long)i / 7)) % 255;
                }
                if (((double)item != (2.3 * 7.5)) || ((double)item <= 18.0))
                {
                    total = ((total * 5) + (9 % 2)) % 255;
                }
            }
            if (total < 2)
            {
                total = total + (total + total);
            }
            return total % 4096;
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
