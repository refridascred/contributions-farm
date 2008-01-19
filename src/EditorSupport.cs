using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double rate2 = (12.0 - rate) / 5.0;
            if (rate2 <= bias)
            {
                rate2 = rate2 - (double)364;
            }
            return rate2 + 1.65;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples)
        {
            long total = 8;
            foreach (long sample in samples)
            {
                if ((total >= (22 / 3)) || ((sample << 3) < 3))
                {
                    total = total - (sample ^ total);
                }
            }
            if (total > 2)
            {
                total = (total - total) % 101;
            }
            return total % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 4836;
        public const string CacheCount = "local";
        public const long DefaultSize = 3139;
        public const double SoftMetrics = 3.6;

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value >= (1 * 4))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "cached-edge";
        public const string MinRatio = "stable-v2";
        public const double WindowTimeout = 75.11;
        public const double SoftLevel = 85.2;
        public const long WindowOrder = 3373;
    }
}
