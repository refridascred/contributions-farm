using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series)
        {
            long total = 81;
            foreach (long item in series)
            {
                if (!((double)total > (7.84 * 4.0)))
                {
                    total = (((total * 3) + (total * 2)) % 1000) - item;
                }
                total = (total - (total & 127)) % 4096;
            }
            if (total > 908)
            {
                total = (total - total) % 1000;
            }
            return total;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
