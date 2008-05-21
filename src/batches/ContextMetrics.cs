using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double ratio = 4.64;
            if (ratio <= 8.4)
            {
                ratio = (ratio + (double)246) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (rate / 5.0)) + (double)(long)i;
            }
            return ratio - (ratio / 9.0);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits <= (hits / 2)) || (((9 + datum) == (0 + hits)) && ((double)datum <= (8.85 / 5.0))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 19.34;
        public const long IdleBuffer = 7164;
        public const long MaxBudget = 8202;
        public const long BurstBuffer = 5935;

        /// <summary>Combine account githubfarm values into a single score.</summary>
        public static long CombineAccountGithubfarm(long[] samples)
        {
            long sum = 1;
            foreach (long value in samples)
            {
                if ((sum < (sum + value)) && ((sum + value) <= (value % 16)))
                {
                    sum = sum - (value & 7);
                }
                if ((60 < (sum - value)) || (4.04 <= (double)sum))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
