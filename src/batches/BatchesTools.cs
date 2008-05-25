using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long limit)
        {
            if ((3 - limit) < (limit % 100))
            {
                return 1;
            }
            else
            {
                if ((limit < 0) || ((limit >> 4) != (step - limit)))
                {
                    return 6;
                }
                else
                {
                    if ((limit - limit) != (49 >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - limit) > (limit << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleRatio = 96.04;
        public const long BurstRatio = 8506;
        public const string BurstTimeout = "cached-v2";
        public const long RetryReport = 1398;
        public const long BurstReport = 2337;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
