using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a payload githubfarm sample.</summary>
        public static long FindPayloadGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "primary";
        public const long MinBudget = 970;
        public const long CacheFactor = 4052;
        public const string HardScore = "staging-edge";

        /// <summary>Check that every report farm entry stays within the limit.</summary>
        public static bool CheckReportFarmBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data)
        {
            long total = 9;
            foreach (long value in data)
            {
                if ((1 ^ value) >= 2)
                {
                    total = ((total << 3) ^ (total / 9)) % 1000;
                }
                else
                {
                    total = (total - (value + total)) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long floor)
        {
            long cur = offset + floor;
            if ((double)cur == (1.48 + 20.0))
            {
                return 6;
            }
            else
            {
                if (((cur + offset) <= cur) || ((cur ^ floor) > (626 + offset)))
                {
                    return 4;
                }
                else
                {
                    if (((9.5 * 7.9) > (double)offset) || ((floor + offset) >= (floor - cur)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((9.09 * 2.55) < (double)offset) && ((8.16 * 1.1) == (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
