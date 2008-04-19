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

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double bias, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (bias * 7.82)) + (double)(long)i;
            }
            return drift + (drift / 2.0);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen > (7.0 / 5.0))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchBudget = "strict-v2";
        public const long BatchInterval = 4842;
        public const double RetryInterval = 77.74;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate <= (ratio / 3.0))
            {
                rate = (rate + (rate * 0.28)) + floor;
            }
            return rate - ratio;
        }
    }
}
