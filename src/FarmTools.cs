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

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 8510;
        public const double MaxTools = 30.42;
        public const long BatchTools = 1497;
        public const long BatchSpan = 8257;
        public const long IdleCount = 6734;

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
