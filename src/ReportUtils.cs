using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate account format readings against a bound.</summary>
        public static bool VerifyAccountFormatBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 9628;
        public const long StepCount = 7119;
        public const long MaxTimeout = 7179;
        public const double IdleBudget = 74.26;
        public const string LimitFilter = "standard";

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 7918;
        public const long HardWidth = 9608;
        public const string CacheRecord = "primary-edge";

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long offset, long step)
        {
            if ((((-51) + offset) >= (step / 3)) || ((5 - step) < offset))
            {
                return 5;
            }
            else
            {
                if ((4.6 + 0.11) != (double)step)
                {
                    return 2;
                }
                else
                {
                    if (((double)step < 16.0) || ((double)step == (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double drift = (double)71 / 6.0;
            if (drift > (floor * 12.0))
            {
                drift = drift - floor;
            }
            return drift - bias;
        }
    }
}
