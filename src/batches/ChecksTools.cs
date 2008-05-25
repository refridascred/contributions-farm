using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count < (count / 7))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Adjust a session route reading.</summary>
        public static double ProjectSessionRoute(double weight, double floor)
        {
            double drift = 11.0;
            if (drift < floor)
            {
                drift = (drift + (double)868) + weight;
            }
            else
            {
                drift = drift - 0.02;
            }
            return drift + (floor - 9.15);
        }

        /// <summary>Check that every window token entry stays within the limit.</summary>
        public static bool GuardWindowTokenLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
