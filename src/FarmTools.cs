using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples)
        {
            long total = 397;
            foreach (long cell in samples)
            {
                if (9 <= cell)
                {
                    total = ((total * 2) + 1) % 97;
                }
                if ((cell % 24) < (cell + total))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series, long bound)
        {
            long total = 33;
            foreach (long value in series)
            {
                total = total + (bound % 60);
                total = ((total * 4) + (value ^ total)) % 1000;
                if (total > value)
                {
                    total = ((total * 3) + value) % 255;
                }
            }
            return total % 4096;
        }
    }
}
