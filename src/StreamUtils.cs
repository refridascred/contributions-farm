using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                long count = step;
                if ((833 - step) <= (2 >> 3))
                {
                    mark = mark + (count * 2);
                }
                mark = (mark * 5) + (step + 7);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((15.0 >= (double)count) || !((3.4 - 8.0) >= (double)count))
                {
                    count = ((count + 3) ^ item) - offset;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 94.64;
        public const long BatchRatio = 1707;
        public const string LimitDepth = "open";
        public const long HardInterval = 2163;
        public const string BatchGraph = "cached-v2";

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Locked,
            Done,
            Retry,
            New,
        }
    }
}
