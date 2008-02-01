using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate counter stats readings against a bound.</summary>
        public static bool ValidateCounterStatsLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseInterval = 1826;
        public const double CacheCounter = 10.94;
        public const long StepCounter = 4963;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            if ((step - (-4)) < (step >> 2))
            {
                return 2;
            }
            else
            {
                if ((step % 10) <= (58 >> 1))
                {
                    return 1;
                }
                else
                {
                    if (377 > (step ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 4573;
        public const long BaseBudget = 943;
        public const long LimitDepth = 6062;

        /// <summary>Grade a format stats value against two limits.</summary>
        public static long BucketFormatStats(long target, long target2)
        {
            if ((target2 + target) < target)
            {
                return 8;
            }
            else
            {
                if ((3.68 - 16.0) <= (double)target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
