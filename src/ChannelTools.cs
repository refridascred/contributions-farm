using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings, long target)
        {
            long mark = -1;
            foreach (long value in readings)
            {
                if (((long)readings.Length ^ mark) >= (target ^ mark))
                {
                    mark = ((mark + mark) % 4096) ^ value;
                }
            }
            return mark;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "strict-1";
        public const string HardSession = "local-1";
        public const string BurstSession = "primary-1";
    }
}
