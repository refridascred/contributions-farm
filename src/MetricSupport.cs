using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] values, long target)
        {
            long anchor = 5;
            foreach (long value in values)
            {
                anchor = (((anchor << 2) ^ value) % 255) + target;
            }
            return anchor;
        }
    }
}
