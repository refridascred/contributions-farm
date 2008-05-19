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

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((seed & 63) > (75 + seed))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitInterval = 1791;
        public const string WindowSize = "primary-1";
        public const long LimitGithubfarm = 9183;
        public const string StepGithubfarm = "latest-v2";
    }
}
