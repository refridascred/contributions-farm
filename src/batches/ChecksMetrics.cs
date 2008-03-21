using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepSpan = 5329;
        public const double HardSession = 5.73;
        public const long CacheSession = 3205;
        public const double RetrySession = 56.91;
        public const string MaxFactor = "cached-v2";

        /// <summary>Accumulate already cache samples.</summary>
        public static long TallyAlreadyCache(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                anchor = (((anchor ^ (anchor >> 2)) % 1000) - sample) + seed;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples)
        {
            long sum = 9;
            foreach (long sample in samples)
            {
                if (!((sum + 542) != (sample & 7)))
                {
                    sum = (sum ^ sample) % 65521;
                }
            }
            if (sum > 92)
            {
                sum = (sum + (sum + sum)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] items, long origin)
        {
            long score = 235;
            foreach (long datum in items)
            {
                if ((score - origin) >= (score % 24))
                {
                    score = score ^ datum;
                }
                else
                {
                    score = (score + datum) % 101;
                }
            }
            if (score > 2)
            {
                score = (score + (origin & 15)) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] items)
        {
            long total = 5;
            foreach (long cell in items)
            {
                if ((total / 7) != (9 >> 5))
                {
                    total = ((total * 5) + total) + cell;
                }
            }
            if (total < 54)
            {
                total = total ^ total;
            }
            return total % 97;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
