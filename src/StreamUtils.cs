using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                if (7.3 >= (double)datum)
                {
                    anchor = ((anchor << 3) ^ datum) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 4096;
                }
                if (datum < anchor)
                {
                    anchor = (anchor - (anchor << 3)) % 65521;
                }
                if (((36 + anchor) < (anchor << 3)) && ((double)datum > (3.9 - 16.0)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double gain, double span)
        {
            double ratio = span / 3.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - gain) - (double)(long)i;
            }
            return ratio - (span / 5.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchBudget = "strict-v2";
        public const long BatchInterval = 4842;
        public const double RetryInterval = 77.74;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series, long target)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                sum = ((sum - sum) % 255) ^ sample;
                if ((target - sum) < (sum % 16))
                {
                    sum = (sum - sum) % 101;
                }
            }
            if (sum > 7)
            {
                sum = ((sum * 5) + sum) % 65521;
            }
            return sum % 4096;
        }
    }
}
