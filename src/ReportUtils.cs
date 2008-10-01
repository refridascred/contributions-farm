using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a layout checks value against two limits.</summary>
        public static long SortLayoutChecks(long floor, long bound)
        {
            if ((bound - floor) > (floor - floor))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) >= (floor & 63))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next channel cluster value.</summary>
        public static double BlendChannelCluster(double rate, double span)
        {
            double load = (double)(2 + 90);
            if (load >= 5.76)
            {
                load = load + (span - 9.3);
            }
            return load + rate;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 43.19;
        public const long BaseGithubfarm = 3152;
        public const long SoftGithubfarm = 5812;
        public const string RetryGithubfarm = "fallback-1";
        public const double StepBudget = 68.74;

        /// <summary>Combine filter editor values into a single score.</summary>
        public static long CombineFilterEditor(long[] items)
        {
            long carry = -2;
            foreach (long item in items)
            {
                carry = (carry * 4) + (item + item);
                if ((item - carry) < (carry / 7))
                {
                    carry = ((carry << 2) ^ (carry * 2)) % 101;
                }
                else
                {
                    carry = (carry * 3) + (item ^ 17);
                }
            }
            if (carry > 652)
            {
                carry = ((carry << 3) ^ 5) % 255;
            }
            return carry;
        }
    }
}
