using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSpan = 4073;
        public const long IdleCache = 8077;
        public const long BaseCache = 2069;
        public const long WindowCache = 5939;

        /// <summary>Define support limits and defaults.</summary>
        public const string StepLevel = "latest-v2";
        public const string LimitSupport = "fallback";
        public const double BatchSupport = 75.03;
        public const double BaseSupport = 82.37;
        public const long StepSupport = 5214;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((count ^ limit) == (limit / 7)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Check that every already format entry stays within the limit.</summary>
        public static bool CheckAlreadyFormatRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
