using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "standard";
        public const long HardFactor = 2530;
        public const string WindowReport = "legacy-v2";
        public const string SoftTimeout = "cached-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitInterval = "legacy";
        public const double BatchScore = 40.18;
        public const double LimitProfile = 17.08;

        /// <summary>Match up support already samples.</summary>
        public static long MatchSupportAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Failed,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample >= (sample & 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
