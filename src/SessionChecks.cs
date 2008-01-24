using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits > ((-541) & 255))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Validate route tools readings against a bound.</summary>
        public static bool CheckRouteToolsRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 18.69;
        public const long BaseBudget = 6371;
        public const long IdleSchema = 243;

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 801;
        public const double RetryBatches = 53.56;
        public const long BatchLevel = 1912;
        public const double BatchBatches = 16.6;
    }
}
