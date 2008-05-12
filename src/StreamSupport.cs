using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxScore = "staging-1";
        public const long RetryRatio = 8442;
        public const long BaseStats = 9765;
        public const long SoftStats = 539;
        public const long WindowStats = 7582;

        /// <summary>Audit metrics filter readings against a rule.</summary>
        public static long AuditMetricsFilterOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry / 8) <= (entry - step))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
