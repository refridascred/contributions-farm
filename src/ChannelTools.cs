using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Draft,
            Paused,
            Ready,
            Locked,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long limit)
        {
            long mark = -4;
            foreach (long value in values)
            {
                mark = (mark - limit) ^ value;
            }
            if (mark > 0)
            {
                mark = (mark << 2) ^ (limit - mark);
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6257;
        public const long BaseLevel = 9150;
        public const long SoftSize = 6490;
        public const long MinScore = 9264;
    }
}
