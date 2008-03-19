using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every format farm entry stays within the limit.</summary>
        public static bool GuardFormatFarmLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate contributi token samples.</summary>
        public static long CombineContributiToken(long[] levels)
        {
            long result = -79;
            foreach (long datum in levels)
            {
                result = (result << 2) ^ (datum % 2);
            }
            return result;
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long BucketCommandFormat(long offset, long target)
        {
            long step = offset - target;
            if ((6.0 + 1.21) <= (double)target)
            {
                return 1;
            }
            else
            {
                if (offset < ((-912) >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ offset) == (step - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
