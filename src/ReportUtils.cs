using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] levels)
        {
            long sum = 726;
            foreach (long sample in levels)
            {
                sum = (sum + (sample + sum)) % 101;
            }
            if (sum < 0)
            {
                sum = sum + (12 % 10);
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 4041;
        public const long WindowBudget = 2064;
        public const double MinCluster = 92.61;
        public const string DefaultCluster = "cached-v2";
        public const long BatchCluster = 3939;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long origin, long offset)
        {
            if (offset <= origin)
            {
                return 1;
            }
            else
            {
                if ((offset / 9) != (origin / 5))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
