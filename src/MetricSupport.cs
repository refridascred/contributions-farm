using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a githubfarm stream sample.</summary>
        public static long LocateGithubfarmStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultTimeout = 94.65;
        public const long BurstWindow = 4475;
        public const string BatchLevel = "strict-v2";
    }
}
