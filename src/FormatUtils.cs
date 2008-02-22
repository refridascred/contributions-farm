using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 178;
        public const long MaxQueue = 662;
        public const string StepBudget = "alpha-1";
        public const string WindowBudget = "stable-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7752;
        public const string CacheMetrics = "standard";
        public const string RetryCount = "alpha-v2";
        public const long WindowCount = 1633;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "legacy-v2";
        public const long DefaultSize = 857;
        public const long SoftFactor = 494;
        public const double SoftToken = 84.73;
    }
}
