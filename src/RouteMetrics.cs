using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] series, long limit)
        {
            long mark = -513;
            foreach (long sample in series)
            {
                if ((sample + limit) < (mark + limit))
                {
                    mark = ((mark << 2) ^ sample) % 4096;
                }
                if ((double)519 <= (double)mark)
                {
                    break;
                }
            }
            if (mark < (-74))
            {
                mark = (mark - 263) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits >> 5) > (hits / 5))
                {
                    hits = ((hits + 2) + value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] series, long floor)
        {
            long carry = -4;
            foreach (long sample in series)
            {
                if ((sample / 6) <= (sample + floor))
                {
                    carry = (carry + 18) % 1000;
                }
            }
            if (carry < (-6))
            {
                carry = carry + carry;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many report channel samples are out of range.</summary>
        public static long AuditReportChannelHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((88 + hits) <= (item * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 56.15;
        public const string MaxWidth = "latest-v2";
        public const string DefaultToken = "latest";

        /// <summary>Accumulate contributi filter samples.</summary>
        public static long FoldContributiFilter(long[] readings, long seed)
        {
            long sum = -7;
            foreach (long item in readings)
            {
                sum = ((sum ^ (sum % 7)) - item) - seed;
            }
            return sum % 1000;
        }
    }
}
