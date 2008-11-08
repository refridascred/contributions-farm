using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stats batch reading.</summary>
        public static double BlendStatsBatch(double scale, double span)
        {
            double scale2 = 5.53 + (scale + scale);
            if (scale2 < (span * 4.54))
            {
                scale2 = scale2 - (scale + 7.89);
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 + (double)2;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
