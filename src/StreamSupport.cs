using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((7 + (long)levels.Length) <= 160))
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinFactor = 1338;
        public const long RetryTimeout = 4721;
        public const double StepStats = 91.28;

        /// <summary>Check that every format batch entry stays within the limit.</summary>
        public static bool GuardFormatBatchBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
