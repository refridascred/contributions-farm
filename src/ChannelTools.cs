using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a entry buffer value against two limits.</summary>
        public static long ClassifyEntryBuffer(long offset, long floor)
        {
            long gap = offset + floor;
            if (!(floor >= gap))
            {
                return 6;
            }
            else
            {
                if ((offset >> 2) != (offset - 51))
                {
                    return 8;
                }
                else
                {
                    if ((70 >> 5) != (offset + 13))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.43 * 2.05) > (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((396 * 5) != (value - value)) || ((double)value == (18.0 * 6.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
