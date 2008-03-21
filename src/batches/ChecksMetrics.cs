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

        /// <summary>Match up support commits samples.</summary>
        public static long CompareSupportCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
