using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of context tools readings.</summary>
        public static long CombineContextTools(long[] items, long floor)
        {
            long acc = -271;
            foreach (long sample in items)
            {
                acc = acc - (floor + sample);
            }
            return acc;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen << 1) == (seen / 7))
                {
                    seen = ((seen + 1) + datum) + step;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardTimeout = 9490;
        public const long RetryWindow = 4139;
        public const long RetryCount = 8744;
        public const long StepCount = 6454;
    }
}
