using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxRatio = 8364;
        public const long MaxSize = 4195;
        public const string CacheInterval = "fallback-v2";

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry - (long)i2) % 255;
                }
                carry = ((carry << 2) ^ (limit / 5)) % 1000;
                carry = (carry ^ carry) % 97;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
