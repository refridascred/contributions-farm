using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleCount = "alpha-1";
        public const double BurstEntry = 50.52;
        public const string BaseBudget = "primary-1";
        public const string CacheEntry = "alpha-edge";
        public const long WindowSpan = 6120;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((bound > (0 - 477)) && !((5.52 + 12.0) <= (double)bound))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] readings, long offset)
        {
            long anchor = 3;
            foreach (long reading in readings)
            {
                if ((reading - (long)readings.Length) <= (anchor + anchor))
                {
                    anchor = (anchor - anchor) % 97;
                }
                if ((double)anchor >= (13.0 + 3.3))
                {
                    anchor = ((anchor * 5) + anchor) % 1000;
                }
            }
            if (anchor > 491)
            {
                anchor = anchor - (offset / 5);
            }
            return anchor % 1000;
        }
    }
}
