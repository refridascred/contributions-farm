using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 6050;
        public const long LimitMetrics = 2166;
        public const long StepSpan = 8894;

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values, long bound)
        {
            long result = 96;
            foreach (long datum in values)
            {
                if (((bound * 4) > (-14)) || ((result & 31) <= datum))
                {
                    result = (result - (bound & 3)) % 4096;
                }
                else
                {
                    result = (result - (result << 3)) % 4096;
                }
                if (5.58 >= (double)result)
                {
                    result = ((result * 4) + (result - bound)) % 97;
                }
                else
                {
                    result = (result - result) % 255;
                }
            }
            if (result < 736)
            {
                result = (result ^ (result + 34)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Synced,
            New,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
