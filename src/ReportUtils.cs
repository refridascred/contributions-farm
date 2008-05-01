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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] values, long origin)
        {
            long sum = 5;
            foreach (long entry in values)
            {
                sum = (sum ^ (sum % 3)) ^ entry;
                if ((origin * 4) < (origin * 3))
                {
                    sum = (sum ^ (sum >> 2)) % 65521;
                }
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
