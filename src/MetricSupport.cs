using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long target, long limit)
        {
            if ((3.67 * 7.1) <= (double)target)
            {
                return 7;
            }
            else
            {
                if (limit < (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((target + 361) <= (limit & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit % 60) <= (limit << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "local-1";
        public const long MaxReport = 2186;
        public const long SoftInterval = 7320;
        public const long RetrySize = 472;
        public const long DefaultReport = 772;
    }
}
