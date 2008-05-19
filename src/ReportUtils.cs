using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBudget = 64.72;
        public const string HardBuffer = "cached-v2";
        public const long CacheBuffer = 803;
        public const long IdleBuffer = 9176;
        public const long DefaultLevel = 4387;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double scale, double floor)
        {
            double ratio = scale;
            if (ratio > (floor * 0.9))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (double)454;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (scale - floor)) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 7423;
        public const long BaseCluster = 637;
        public const long CacheCount = 9021;
        public const string CacheRatio = "open-1";
    }
}
