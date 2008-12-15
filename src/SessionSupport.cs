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

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double ratio, double offset)
        {
            double scale = offset;
            if (scale > (ratio / 7.0))
            {
                scale = scale - (double)5;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale - 18.0;
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
