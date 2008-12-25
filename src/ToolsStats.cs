using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every checks record entry stays within the limit.</summary>
        public static bool GuardChecksRecordBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardInterval = 3983;
        public const long CacheBudget = 18;
        public const long IdleInterval = 6437;
        public const string BurstLevel = "local-v2";
        public const long BaseCount = 1463;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate cache channel readings against a bound.</summary>
        public static bool VerifyCacheChannelLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchLevel = "primary-edge";
        public const string DefaultSpan = "open-edge";
        public const long SoftTimeout = 8104;
    }
}
