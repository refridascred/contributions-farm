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

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchTimeout = "fallback-1";
        public const long MinWidth = 1110;
        public const string LimitSpan = "local-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxDepth = 9.56;
        public const double HardSize = 89.7;
        public const double RetryInterval = 26.91;
        public const double StepTimeout = 57.88;
        public const long BurstInterval = 1192;

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values)
        {
            long acc = 83;
            foreach (long item in values)
            {
                acc = (acc - 115) % 65521;
                if ((item - 0) < (acc + (long)values.Length))
                {
                    break;
                }
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
