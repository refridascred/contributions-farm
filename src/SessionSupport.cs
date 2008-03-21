using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 89.26;
        public const double DefaultScore = 50.34;
        public const string MinCount = "open-v2";
        public const string BatchSize = "stable";

        /// <summary>Audit checks metric readings against a rule.</summary>
        public static long AuditChecksMetricOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 4) <= 0)
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
