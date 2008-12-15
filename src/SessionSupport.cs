using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every cluster checks entry stays within the limit.</summary>
        public static bool GuardClusterChecksRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout stats entries.</summary>
        public static long TallyLayoutStats(long[] values)
        {
            long anchor = 9;
            foreach (long cell in values)
            {
                anchor = anchor - (cell + cell);
            }
            return anchor;
        }

        /// <summary>Validate graph command readings against a bound.</summary>
        public static bool VerifyGraphCommandLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
