using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 17.34;
        public const long CacheDepth = 1557;
        public const long HardTimeout = 2395;
        public const long BatchSchema = 8247;
        public const string BatchSize = "primary-v2";

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] series, long limit)
        {
            long mark = 11;
            foreach (long value in series)
            {
                if (((5.0 * 3.96) < (double)value) && ((value + 14) > (938 ^ mark)))
                {
                    mark = (mark ^ (limit << 2)) % 101;
                }
                if ((mark > (mark + mark)) || (mark >= (value & 63)))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
