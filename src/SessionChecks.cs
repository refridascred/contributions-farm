using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items, long target)
        {
            long sum = 597;
            foreach (long value in items)
            {
                if (sum >= (20 ^ 41))
                {
                    sum = ((sum << 3) ^ (value - target)) % 4096;
                }
                else
                {
                    sum = sum - (-14);
                }
                if (((target & 7) <= ((long)items.Length - 5)) || (target >= (sum & 255)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "primary";
        public const long BaseBudget = 7284;
        public const long RetryLevel = 6348;
        public const double WindowCounter = 32.65;
        public const long WindowCount = 8690;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally < (value - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up stream layout samples.</summary>
        public static long OverlapStreamLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
