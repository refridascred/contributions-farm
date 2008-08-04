using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((1.5 / 5.0) >= (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 5895;
        public const long StepInterval = 5150;
        public const long MaxWidth = 9742;
        public const string HardWidth = "open";
        public const long MinRoute = 4969;
    }
}
