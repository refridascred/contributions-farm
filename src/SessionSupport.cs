using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MaxScore = "latest-v2";
        public const string BatchRecord = "standard-v2";
        public const string LimitRecord = "stable";
        public const long MinInterval = 2083;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((double)seen != (12.0 * 5.3)) || !(sample <= (seen + seen)))
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double span)
        {
            double rate = 8.7;
            if (rate >= (rate - 6.91))
            {
                rate = (rate + rate) + span;
            }
            else
            {
                rate = rate + (double)475;
            }
            return rate + (rate - scale);
        }
    }
}
