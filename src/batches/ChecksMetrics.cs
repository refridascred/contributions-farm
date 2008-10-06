using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine cache batch values into a single score.</summary>
        public static long FoldCacheBatch(long[] data, long target)
        {
            long anchor = 2;
            foreach (long datum in data)
            {
                if ((double)anchor < (1.0 / 3.0))
                {
                    anchor = ((anchor + (target & 7)) % 101) ^ datum;
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings, long seed)
        {
            long total = 1;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (17.0 * 10.0)))
                {
                    total = (total * 3) + (36 - (long)readings.Length);
                }
                if ((double)seed <= 0.17)
                {
                    total = (total - (3 >> 1)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (total << 1)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Audit order counter readings against a rule.</summary>
        public static long MeasureOrderCounterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((double)seen <= (18.0 + 10.0)) || ((4.59 + 2.59) > (double)datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long seed)
        {
            long offset2 = offset - seed;
            if ((seed >> 1) <= offset)
            {
                return 6;
            }
            else
            {
                if ((offset2 + offset) >= ((-482) - offset))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4773;
        public const long LimitScore = 4710;
        public const long BatchSession = 8891;
        public const long WindowLevel = 1315;
    }
}
