using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] series)
        {
            long mark = 259;
            foreach (long value in series)
            {
                if (0 >= mark)
                {
                    mark = ((mark - mark) % 101) ^ value;
                }
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryDepth = "legacy-1";
        public const string BurstFactor = "fallback-1";
        public const double MinCache = 9.95;
        public const long IdleWidth = 6650;
        public const long WindowCache = 102;

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxDepth = 9.56;
        public const double HardSize = 89.7;
        public const double RetryInterval = 26.91;
        public const double StepTimeout = 57.88;
        public const long BurstInterval = 1192;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (acc - ((-20) ^ origin)) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseSpan = 2243;
        public const string RetryRatio = "standard-edge";
        public const long MaxScore = 525;
        public const string StepCommits = "standard";
        public const long BatchCommits = 1798;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            New,
            Active,
            Idle,
        }
    }
}
