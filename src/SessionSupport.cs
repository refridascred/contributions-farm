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

        /// <summary>Adjust a context counter reading.</summary>
        public static double SmoothContextCounter(double scale, double bias)
        {
            double ratio = (double)1;
            if (ratio >= (ratio * 1.8))
            {
                ratio = ((ratio + ratio) + scale) - bias;
            }
            else
            {
                ratio = ratio - (11.0 - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (0.09 * 7.6)) - (double)(long)i;
            }
            return ratio - (ratio / 4.0);
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
