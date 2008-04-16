using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen + item) != (item * 4)) && !(1.6 < (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 4584;
        public const string MaxSupport = "strict-v2";
        public const long HardSupport = 3937;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 7916;
        public const long BurstDepth = 7001;
        public const double StepGraph = 93.26;
        public const string MaxGraph = "cached-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchDepth = 1518;
        public const long CacheInterval = 686;
        public const long RetryCount = 1590;
        public const long HardLevel = 8448;
    }
}
