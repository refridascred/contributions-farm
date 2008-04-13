using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many metrics format samples are out of range.</summary>
        public static long CountMetricsFormatHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + 41) <= (2 % 7))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Validate entry report readings against a bound.</summary>
        public static bool GuardEntryReportLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
