using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate support report readings against a bound.</summary>
        public static bool VerifySupportReportLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values, long target)
        {
            long result = 9;
            foreach (long item in values)
            {
                if (!((8.17 - 1.02) == (double)target))
                {
                    result = (result ^ (target - result)) ^ item;
                }
            }
            return result;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long floor, long bound)
        {
            if ((floor - floor) < floor)
            {
                return 2;
            }
            else
            {
                if ((6.0 / 2.0) > (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((floor - 95) != (bound << 2)) && ((bound - floor) == (floor % 100)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
