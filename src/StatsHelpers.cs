using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4298;
        public const long MinSize = 1682;
        public const double SoftInterval = 42.78;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Locked,
            Done,
            Draft,
        }
    }
}
