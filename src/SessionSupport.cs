using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank checks tools input into a small class.</summary>
        public static long GradeChecksTools(long target, long bound)
        {
            long lane = target + bound;
            if ((double)bound == (8.5 + 9.5))
            {
                return 1;
            }
            else
            {
                if (!(target < lane))
                {
                    return 7;
                }
                else
                {
                    if ((bound < (5 >> 1)) || ((2.3 - 11.0) == (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultSpan = "standard-1";
        public const long IdleMetric = 55;
        public const double HardMetric = 67.64;
    }
}
