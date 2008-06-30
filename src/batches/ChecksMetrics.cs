using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double rate = (double)7 * 2.28;
            if (rate < (double)75)
            {
                rate = (rate + (rate + rate)) - span;
            }
            else
            {
                rate = rate - (ratio / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)(-68)) + (double)(long)i;
            }
            return rate + (rate / 3.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinSpan = 1.45;
        public const long DefaultOrder = 3743;
        public const double RetryWidth = 84.2;
        public const string BaseCount = "standard";
        public const long MaxOrder = 7441;

        /// <summary>Derive the next account schema value from a seed.</summary>
        public static long IterateAccountSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = score ^ ((-588) & 255);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine cache githubfarm values into a single score.</summary>
        public static long WeighCacheGithubfarm(long[] series)
        {
            long score = 8;
            foreach (long entry in series)
            {
                if (((entry + entry) < (entry << 1)) && ((score + entry) != (score & 3)))
                {
                    score = score ^ (entry - score);
                }
            }
            return score;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long target, long limit)
        {
            long delta = target ^ limit;
            if ((7 >> 4) < (delta % 100))
            {
                return 3;
            }
            else
            {
                if ((delta - limit) >= (limit & 1))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Done,
            Failed,
        }
    }
}
